using System;
using System.Linq;
using System.Collections;

namespace Calc
{
    public class CalculateTree
    {
        CalculateTree leftNode;
        CalculateTree rightNode;
        String value;
        Double calculatedValue;
        private int systemBase = 11;
        private int accuracy = 5;

        public Double calculate()
        {
            Double x1 = 0;
            if (leftNode != null)
            {
                x1 = leftNode.calculate();
            }
            Double x2 = 0;
            if (rightNode != null)
            {
                x2 = rightNode.calculate();
            }
            switch (value)
            {
                case "+":
                    calculatedValue = x1 + x2;
                    return calculatedValue;
                case "-":
                    calculatedValue = x1 - x2;
                    return calculatedValue;
                case "*":
                    calculatedValue = x1 * x2;
                    return calculatedValue;
                case "/":
                    if (x2 == 0)
                    {
                        throw new Exception("Zero Division");
                    }
                    calculatedValue = x1 / x2;
                    return calculatedValue;
            }
            calculatedValue = double11ToDouble(value);
            return calculatedValue;
        }

        private static bool isDouble11(String number)
        {
            int countDots = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if ((number[i] != '0') && (number[i] != '1') && (number[i] != '2') && (number[i] != '3')
                     && (number[i] != '4') && (number[i] != '5') && (number[i] != '6') && (number[i] != '7')
                     && (number[i] != '8') && (number[i] != '9') && (number[i] != 'A') && (number[i] != '.'))
                {
                    return false;
                }
                if (number[i] == '.')
                {
                    countDots++;
                    if (countDots > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public CalculateTree (String exp)
        {
            while (true)
            {
                int pos = lastStepPosition(exp);
                if (pos != -1)
                {
                    value = exp[pos].ToString();
                    String expLeft = exp.Substring(0, pos);
                    String expRight = exp.Substring(pos + 1, exp.Length - pos - 1);
                    if (expLeft.Length == 0)
                    {
                        leftNode = null;
                        if ((value == "*") || (value == "/")) {
                            throw new Exception("Sign Error");
                        }
                    }
                    else
                    {
                        leftNode = new CalculateTree(expLeft);
                    }

                    if (expRight.Length == 0)
                    {
                        throw new Exception("Sign Error");
                    }
                    else
                    {
                        rightNode = new CalculateTree(expRight);
                    }
                    break;
                }
                else
                {
                    if ((exp.Length > 0) && (exp[0] == '(') && (exp[exp.Length - 1] == ')'))
                    {
                        exp = exp.Remove(exp.Length - 1, 1).Remove(0, 1);
                    } else
                    {
                        value = exp;
                        break;
                    }
                }

            }

        }

        private static int lastStepPosition(String exp)
        {
            int bracketCount = 0;
            int multDivPosition = -1;
            for (int i = exp.Length - 1; i > -1 ; i--)
            {
                if (exp[i] == '(')
                {
                    bracketCount -= 1;
                }
                if (exp[i] == ')')
                {
                    bracketCount += 1;
                }
                if (bracketCount == 0)
                {
                    if ((exp[i] == '+') || (exp[i] == '-'))
                    {
                        return i;
                    }
                    if (((exp[i] == '*') || (exp[i] == '/')) && (multDivPosition == -1))
                    {
                        multDivPosition = i;
                    }
                }
                if (bracketCount < 0)
                {
                    throw new Exception("Brackets Error");
                }
            }
            if (bracketCount > 0)
            {
                throw new Exception("Brackets Error");
            }
            return multDivPosition;
        }

        public Double double11ToDouble(String number)
        {
            if (!isDouble11(number))
            {
                throw new Exception("Not Double11");
            }
            Double res = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 'A')
                {
                    res = res * this.systemBase + 10;
                }
                else
                {
                    int s = 0;
                    if (Int32.TryParse(number[i].ToString(), out s))
                    {
                        res = res * systemBase + s;
                    }
                }
            }
            if (number.IndexOf(".") != -1)
            {
                for (int i = 0; i < number.Length - number.IndexOf(".") - 1; i++)
                {
                    res = res / systemBase;
                }
            }
            return res;
        }

        public String getResult()
        {
            Double number = this.calculatedValue;
            Int64 integer = (Int64)Math.Abs(number);
            if (integer > 25937424601)
            {
                throw new Exception("Big Numbers");
            }
            Double fraction = Math.Abs(number) - integer;
            for (int i = 0; i < accuracy; i++)
            {
                fraction *= 11;
            }
            string resultFrac = "";
            Int64 x = (Int64) fraction;
            while (x != 0)
            {
                if (x % 11 == 10)
                {
                    resultFrac = "A" + resultFrac;
                }
                else
                {
                    resultFrac = (x % 11).ToString() + resultFrac;
                }
                x = x / 11;
            }
            for (int i = 0; resultFrac.Length < 5; i++)
            {
                resultFrac = "0" + resultFrac;
            }
            x = integer;
            string resultInt = "";
            while (x != 0)
            {
                if (x % 11 == 10)
                {
                    resultInt = "A" + resultInt;
                }
                else
                {
                    resultInt = (x % 11).ToString() + resultInt;
                }
                x = x / 11;
            }
            if (resultInt == "")
            {
                resultInt = "0";
            }
            String sign = "";
            if (number < 0)
            {
                sign = "-";
            }
            return sign + resultInt + "." + resultFrac;
        }
    }
}
