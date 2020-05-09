namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.leftBracketButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.rightBracketButton = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonNumberA = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(236, 272);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(50, 106);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractionButton.Location = new System.Drawing.Point(180, 272);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(50, 50);
            this.subtractionButton.TabIndex = 1;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // additionButton
            // 
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionButton.Location = new System.Drawing.Point(180, 328);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(50, 50);
            this.additionButton.TabIndex = 2;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // leftBracketButton
            // 
            this.leftBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBracketButton.Location = new System.Drawing.Point(180, 160);
            this.leftBracketButton.Name = "leftBracketButton";
            this.leftBracketButton.Size = new System.Drawing.Size(50, 50);
            this.leftBracketButton.TabIndex = 3;
            this.leftBracketButton.Text = "(";
            this.leftBracketButton.UseVisualStyleBackColor = true;
            this.leftBracketButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(180, 216);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(50, 50);
            this.multiplicationButton.TabIndex = 4;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(236, 216);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(50, 50);
            this.divisionButton.TabIndex = 5;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // rightBracketButton
            // 
            this.rightBracketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBracketButton.Location = new System.Drawing.Point(236, 160);
            this.rightBracketButton.Name = "rightBracketButton";
            this.rightBracketButton.Size = new System.Drawing.Size(50, 50);
            this.rightBracketButton.TabIndex = 6;
            this.rightBracketButton.Text = ")";
            this.rightBracketButton.UseVisualStyleBackColor = true;
            this.rightBracketButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber6.Location = new System.Drawing.Point(124, 216);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber6.TabIndex = 7;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber3.Location = new System.Drawing.Point(124, 272);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber3.TabIndex = 8;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber5.Location = new System.Drawing.Point(68, 216);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber5.TabIndex = 9;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber4.Location = new System.Drawing.Point(12, 216);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber4.TabIndex = 10;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber7.Location = new System.Drawing.Point(12, 160);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber7.TabIndex = 11;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber8.Location = new System.Drawing.Point(68, 160);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber8.TabIndex = 12;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber9.Location = new System.Drawing.Point(124, 160);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber9.TabIndex = 13;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber1.Location = new System.Drawing.Point(12, 272);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber1.TabIndex = 14;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber2.Location = new System.Drawing.Point(68, 272);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber2.TabIndex = 15;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.Button_Click);
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotButton.Location = new System.Drawing.Point(124, 328);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(50, 50);
            this.dotButton.TabIndex = 16;
            this.dotButton.Text = ",";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber0.Location = new System.Drawing.Point(12, 328);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(50, 50);
            this.buttonNumber0.TabIndex = 17;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.Button_Click);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTextBox.Location = new System.Drawing.Point(12, 12);
            this.taskTextBox.Multiline = true;
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.ReadOnly = true;
            this.taskTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.taskTextBox.Size = new System.Drawing.Size(274, 72);
            this.taskTextBox.TabIndex = 18;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(236, 90);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(50, 64);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonNumberA
            // 
            this.buttonNumberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumberA.Location = new System.Drawing.Point(68, 328);
            this.buttonNumberA.Name = "buttonNumberA";
            this.buttonNumberA.Size = new System.Drawing.Size(50, 50);
            this.buttonNumberA.TabIndex = 20;
            this.buttonNumberA.Text = "A";
            this.buttonNumberA.UseVisualStyleBackColor = true;
            this.buttonNumberA.Click += new System.EventHandler(this.Button_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(12, 90);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 64);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "←";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(68, 90);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(162, 64);
            this.resultTextBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 390);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.buttonNumberA);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber1);
            this.Controls.Add(this.buttonNumber9);
            this.Controls.Add(this.buttonNumber8);
            this.Controls.Add(this.buttonNumber7);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber6);
            this.Controls.Add(this.rightBracketButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.leftBracketButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.resultButton);
            this.MaximumSize = new System.Drawing.Size(314, 429);
            this.MinimumSize = new System.Drawing.Size(314, 429);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button leftBracketButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button rightBracketButton;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button buttonNumberA;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

