using System;
using System.Windows.Forms;
using Calc;

namespace Calc
{

    public partial class Form1 : Form
    {
        bool update = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (update)
            {
                taskTextBox.Text = "";
                resultTextBox.Text = "";
                update = false;
            }
            switch (((Button)sender).Name)
            {
                case "clearButton":
                    taskTextBox.Text = "";
                    resultTextBox.Text = "";
                    break;
                case "deleteButton":
                    if (taskTextBox.Text.Length>0)
                    {
                        taskTextBox.Text = taskTextBox.Text.Remove(taskTextBox.Text.Length - 1);
                    }
                    break;
                case "buttonNumber0":
                    taskTextBox.Text += "0";
                    break;
                case "buttonNumber1":
                    taskTextBox.Text += "1";
                    break;
                case "buttonNumber2":
                    taskTextBox.Text += "2";
                    break;
                case "buttonNumber3":
                    taskTextBox.Text += "3";
                    break;
                case "buttonNumber4":
                    taskTextBox.Text += "4";
                    break;
                case "buttonNumber5":
                    taskTextBox.Text += "5";
                    break;
                case "buttonNumber6":
                    taskTextBox.Text += "6";
                    break;
                case "buttonNumber7":
                    taskTextBox.Text += "7";
                    break;
                case "buttonNumber8":
                    taskTextBox.Text += "8";
                    break;
                case "buttonNumber9":
                    taskTextBox.Text += "9";
                    break;
                case "buttonNumberA":
                    taskTextBox.Text += "A";
                    break;
                case "leftBracketButton":
                    taskTextBox.Text += "(";
                    break;
                case "rightBracketButton":
                    taskTextBox.Text += ")";
                    break;
                case "multiplicationButton":
                    taskTextBox.Text += "*";
                    break;
                case "divisionButton":
                    taskTextBox.Text += "/";
                    break;
                case "additionButton":
                    taskTextBox.Text += "+";
                    break;
                case "subtractionButton":
                    taskTextBox.Text += "-";
                    break;
                case "dotButton":
                    taskTextBox.Text += ".";
                    break;
                case "resultButton" :
                    try
                    {
                        CalculateTree calc = new CalculateTree(taskTextBox.Text);
                        calc.calculate();
                        resultTextBox.Text = calc.getResult();
                    } catch (Exception exep)
                    {
                        resultTextBox.Text = exep.Message;
                    }
                    update = true;
                    break;
            }
        }
    }
}
