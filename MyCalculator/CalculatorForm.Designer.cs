namespace MyCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Sign = new MyCalculator.SignButton();
            this.Multiply = new MyCalculator.ArithmeticButton();
            this.Divide = new MyCalculator.ArithmeticButton();
            this.Subtract = new MyCalculator.ArithmeticButton();
            this.Backspace = new MyCalculator.BackSpaceButton();
            this.ClearAll = new MyCalculator.ClearAllButton();
            this.ClearEntry = new MyCalculator.ClearEntryButton();
            this.Add = new MyCalculator.ArithmeticButton();
            this.OperationDisplay = new MyCalculator.OperationDisplay();
            this.CurrentDisplay = new MyCalculator.CurrentDisplay();
            this.Equal = new MyCalculator.OperatorButton();
            this.DecimalPoint = new MyCalculator.OperatorButton();
            this.NumpadNine = new MyCalculator.NumberButton();
            this.NumpadEight = new MyCalculator.NumberButton();
            this.NumpadSeven = new MyCalculator.NumberButton();
            this.NumpadSix = new MyCalculator.NumberButton();
            this.NumpadFive = new MyCalculator.NumberButton();
            this.NumpadFour = new MyCalculator.NumberButton();
            this.NumpadThree = new MyCalculator.NumberButton();
            this.NumpadTwo = new MyCalculator.NumberButton();
            this.NumpadOne = new MyCalculator.NumberButton();
            this.NumpadZero = new MyCalculator.NumberButton();
            this.SuspendLayout();
            // 
            // Sign
            // 
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.Location = new System.Drawing.Point(12, 417);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(80, 60);
            this.Sign.TabIndex = 14;
            this.Sign.Text = "+/-";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(270, 219);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(80, 60);
            this.Multiply.TabIndex = 13;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(270, 153);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(80, 60);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(270, 285);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(80, 60);
            this.Subtract.TabIndex = 12;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backspace.Location = new System.Drawing.Point(184, 153);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(80, 60);
            this.Backspace.TabIndex = 11;
            this.Backspace.Text = "⌫";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(98, 153);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(80, 60);
            this.ClearAll.TabIndex = 10;
            this.ClearAll.Text = "C";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // ClearEntry
            // 
            this.ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntry.Location = new System.Drawing.Point(12, 153);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(80, 60);
            this.ClearEntry.TabIndex = 9;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(270, 351);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 60);
            this.Add.TabIndex = 8;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // OperationDisplay
            // 
            this.OperationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationDisplay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OperationDisplay.Location = new System.Drawing.Point(12, 27);
            this.OperationDisplay.Name = "OperationDisplay";
            this.OperationDisplay.Size = new System.Drawing.Size(325, 47);
            this.OperationDisplay.TabIndex = 7;
            this.OperationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentDisplay
            // 
            this.CurrentDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDisplay.Location = new System.Drawing.Point(12, 74);
            this.CurrentDisplay.Name = "CurrentDisplay";
            this.CurrentDisplay.Size = new System.Drawing.Size(338, 71);
            this.CurrentDisplay.TabIndex = 6;
            this.CurrentDisplay.Text = "0";
            this.CurrentDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Equal.Location = new System.Drawing.Point(270, 417);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(80, 60);
            this.Equal.TabIndex = 2;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // DecimalPoint
            // 
            this.DecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DecimalPoint.Location = new System.Drawing.Point(184, 417);
            this.DecimalPoint.Name = "DecimalPoint";
            this.DecimalPoint.Size = new System.Drawing.Size(80, 60);
            this.DecimalPoint.TabIndex = 2;
            this.DecimalPoint.Text = ".";
            this.DecimalPoint.UseVisualStyleBackColor = true;
            this.DecimalPoint.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadNine
            // 
            this.NumpadNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadNine.Location = new System.Drawing.Point(184, 219);
            this.NumpadNine.Name = "NumpadNine";
            this.NumpadNine.Size = new System.Drawing.Size(80, 60);
            this.NumpadNine.TabIndex = 1;
            this.NumpadNine.Text = "9";
            this.NumpadNine.UseVisualStyleBackColor = true;
            this.NumpadNine.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadEight
            // 
            this.NumpadEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadEight.Location = new System.Drawing.Point(98, 219);
            this.NumpadEight.Name = "NumpadEight";
            this.NumpadEight.Size = new System.Drawing.Size(80, 60);
            this.NumpadEight.TabIndex = 1;
            this.NumpadEight.Text = "8";
            this.NumpadEight.UseVisualStyleBackColor = true;
            this.NumpadEight.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadSeven
            // 
            this.NumpadSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadSeven.Location = new System.Drawing.Point(12, 219);
            this.NumpadSeven.Name = "NumpadSeven";
            this.NumpadSeven.Size = new System.Drawing.Size(80, 60);
            this.NumpadSeven.TabIndex = 1;
            this.NumpadSeven.Text = "7";
            this.NumpadSeven.UseVisualStyleBackColor = true;
            this.NumpadSeven.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadSix
            // 
            this.NumpadSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadSix.Location = new System.Drawing.Point(184, 285);
            this.NumpadSix.Name = "NumpadSix";
            this.NumpadSix.Size = new System.Drawing.Size(80, 60);
            this.NumpadSix.TabIndex = 1;
            this.NumpadSix.Text = "6";
            this.NumpadSix.UseVisualStyleBackColor = true;
            this.NumpadSix.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadFive
            // 
            this.NumpadFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadFive.Location = new System.Drawing.Point(98, 285);
            this.NumpadFive.Name = "NumpadFive";
            this.NumpadFive.Size = new System.Drawing.Size(80, 60);
            this.NumpadFive.TabIndex = 1;
            this.NumpadFive.Text = "5";
            this.NumpadFive.UseVisualStyleBackColor = true;
            this.NumpadFive.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadFour
            // 
            this.NumpadFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadFour.Location = new System.Drawing.Point(12, 285);
            this.NumpadFour.Name = "NumpadFour";
            this.NumpadFour.Size = new System.Drawing.Size(80, 60);
            this.NumpadFour.TabIndex = 1;
            this.NumpadFour.Text = "4";
            this.NumpadFour.UseVisualStyleBackColor = true;
            this.NumpadFour.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadThree
            // 
            this.NumpadThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadThree.Location = new System.Drawing.Point(184, 351);
            this.NumpadThree.Name = "NumpadThree";
            this.NumpadThree.Size = new System.Drawing.Size(80, 60);
            this.NumpadThree.TabIndex = 1;
            this.NumpadThree.Text = "3";
            this.NumpadThree.UseVisualStyleBackColor = true;
            this.NumpadThree.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadTwo
            // 
            this.NumpadTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadTwo.Location = new System.Drawing.Point(98, 351);
            this.NumpadTwo.Name = "NumpadTwo";
            this.NumpadTwo.Size = new System.Drawing.Size(80, 60);
            this.NumpadTwo.TabIndex = 1;
            this.NumpadTwo.Text = "2";
            this.NumpadTwo.UseVisualStyleBackColor = true;
            this.NumpadTwo.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadOne
            // 
            this.NumpadOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadOne.Location = new System.Drawing.Point(12, 351);
            this.NumpadOne.Name = "NumpadOne";
            this.NumpadOne.Size = new System.Drawing.Size(80, 60);
            this.NumpadOne.TabIndex = 1;
            this.NumpadOne.Text = "1";
            this.NumpadOne.UseVisualStyleBackColor = true;
            this.NumpadOne.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadZero
            // 
            this.NumpadZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadZero.Location = new System.Drawing.Point(98, 417);
            this.NumpadZero.Name = "NumpadZero";
            this.NumpadZero.Size = new System.Drawing.Size(80, 60);
            this.NumpadZero.TabIndex = 1;
            this.NumpadZero.Text = "0";
            this.NumpadZero.UseVisualStyleBackColor = true;
            this.NumpadZero.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 481);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.OperationDisplay);
            this.Controls.Add(this.CurrentDisplay);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.DecimalPoint);
            this.Controls.Add(this.NumpadNine);
            this.Controls.Add(this.NumpadEight);
            this.Controls.Add(this.NumpadSeven);
            this.Controls.Add(this.NumpadSix);
            this.Controls.Add(this.NumpadFive);
            this.Controls.Add(this.NumpadFour);
            this.Controls.Add(this.NumpadThree);
            this.Controls.Add(this.NumpadTwo);
            this.Controls.Add(this.NumpadOne);
            this.Controls.Add(this.NumpadZero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.Text = "小算盤";
            this.ResumeLayout(false);

        }

        #endregion
        private NumberButton NumpadZero;
        private NumberButton NumpadOne;
        private NumberButton NumpadTwo;
        private NumberButton NumpadThree;
        private NumberButton NumpadFour;
        private NumberButton NumpadFive;
        private NumberButton NumpadSix;
        private NumberButton NumpadSeven;
        private NumberButton NumpadEight;
        private NumberButton NumpadNine;
        private OperatorButton DecimalPoint;
        private OperatorButton Equal;
        private CurrentDisplay CurrentDisplay;
        private OperationDisplay OperationDisplay;
        private ArithmeticButton Add;
        private ClearEntryButton ClearEntry;
        private ClearAllButton ClearAll;
        private BackSpaceButton Backspace;
        private ArithmeticButton Subtract;
        private ArithmeticButton Divide;
        private ArithmeticButton Multiply;
        private SignButton Sign;
    }
}

