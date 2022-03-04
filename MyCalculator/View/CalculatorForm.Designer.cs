namespace MyCalculator.View
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
            this.SquareRootButton1 = new MyCalculator.View.SquareRootButton();
            this.Equal = new MyCalculator.View.EqualButton();
            this.DecimalPoint = new MyCalculator.View.DecimalPointButton();
            this.Sign = new MyCalculator.View.SignButton();
            this.Multiply = new MyCalculator.View.ArithmeticButton();
            this.Divide = new MyCalculator.View.ArithmeticButton();
            this.Subtract = new MyCalculator.View.ArithmeticButton();
            this.Backspace = new MyCalculator.View.BackSpaceButton();
            this.ClearAll = new MyCalculator.View.ClearAllButton();
            this.ClearEntry = new MyCalculator.View.ClearEntryButton();
            this.Add = new MyCalculator.View.ArithmeticButton();
            this.OperationDisplay = new MyCalculator.View.OperationDisplay();
            this.CurrentDisplay = new MyCalculator.View.CurrentDisplay();
            this.NumpadNine = new MyCalculator.View.NumberButton();
            this.NumpadEight = new MyCalculator.View.NumberButton();
            this.NumpadSeven = new MyCalculator.View.NumberButton();
            this.NumpadSix = new MyCalculator.View.NumberButton();
            this.NumpadFive = new MyCalculator.View.NumberButton();
            this.NumpadFour = new MyCalculator.View.NumberButton();
            this.NumpadThree = new MyCalculator.View.NumberButton();
            this.NumpadTwo = new MyCalculator.View.NumberButton();
            this.NumpadOne = new MyCalculator.View.NumberButton();
            this.NumpadZero = new MyCalculator.View.NumberButton();
            this.LeftParenthesis = new MyCalculator.View.ParenthesisButton();
            this.RightParenthesis = new MyCalculator.View.ParenthesisButton();
            this.SuspendLayout();
            // 
            // SquareRootButton1
            // 
            this.SquareRootButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareRootButton1.Location = new System.Drawing.Point(1, 223);
            this.SquareRootButton1.Name = "SquareRootButton1";
            this.SquareRootButton1.Size = new System.Drawing.Size(80, 60);
            this.SquareRootButton1.TabIndex = 17;
            this.SquareRootButton1.Text = "√";
            this.SquareRootButton1.UseVisualStyleBackColor = true;
            this.SquareRootButton1.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(241, 403);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(80, 120);
            this.Equal.TabIndex = 16;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // DecimalPoint
            // 
            this.DecimalPoint.BackColor = System.Drawing.SystemColors.Control;
            this.DecimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalPoint.Location = new System.Drawing.Point(161, 463);
            this.DecimalPoint.Name = "DecimalPoint";
            this.DecimalPoint.Size = new System.Drawing.Size(80, 60);
            this.DecimalPoint.TabIndex = 15;
            this.DecimalPoint.Text = ".";
            this.DecimalPoint.UseVisualStyleBackColor = false;
            this.DecimalPoint.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Sign
            // 
            this.Sign.BackColor = System.Drawing.SystemColors.Control;
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.Location = new System.Drawing.Point(1, 463);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(80, 60);
            this.Sign.TabIndex = 14;
            this.Sign.Text = "+/-";
            this.Sign.UseVisualStyleBackColor = false;
            this.Sign.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(241, 223);
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
            this.Divide.Location = new System.Drawing.Point(241, 163);
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
            this.Subtract.Location = new System.Drawing.Point(241, 283);
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
            this.Backspace.Location = new System.Drawing.Point(161, 163);
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
            this.ClearAll.Location = new System.Drawing.Point(81, 163);
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
            this.ClearEntry.Location = new System.Drawing.Point(1, 163);
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
            this.Add.Location = new System.Drawing.Point(241, 343);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 60);
            this.Add.TabIndex = 8;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // OperationDisplay
            // 
            this.OperationDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationDisplay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OperationDisplay.Location = new System.Drawing.Point(1, 40);
            this.OperationDisplay.Name = "OperationDisplay";
            this.OperationDisplay.Size = new System.Drawing.Size(309, 39);
            this.OperationDisplay.TabIndex = 7;
            this.OperationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrentDisplay
            // 
            this.CurrentDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDisplay.Location = new System.Drawing.Point(1, 74);
            this.CurrentDisplay.Name = "CurrentDisplay";
            this.CurrentDisplay.Size = new System.Drawing.Size(315, 76);
            this.CurrentDisplay.TabIndex = 6;
            this.CurrentDisplay.Text = "0";
            this.CurrentDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumpadNine
            // 
            this.NumpadNine.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadNine.Location = new System.Drawing.Point(161, 283);
            this.NumpadNine.Name = "NumpadNine";
            this.NumpadNine.Size = new System.Drawing.Size(80, 60);
            this.NumpadNine.TabIndex = 1;
            this.NumpadNine.Text = "9";
            this.NumpadNine.UseVisualStyleBackColor = false;
            this.NumpadNine.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadEight
            // 
            this.NumpadEight.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadEight.Location = new System.Drawing.Point(81, 283);
            this.NumpadEight.Name = "NumpadEight";
            this.NumpadEight.Size = new System.Drawing.Size(80, 60);
            this.NumpadEight.TabIndex = 1;
            this.NumpadEight.Text = "8";
            this.NumpadEight.UseVisualStyleBackColor = false;
            this.NumpadEight.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadSeven
            // 
            this.NumpadSeven.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadSeven.Location = new System.Drawing.Point(1, 283);
            this.NumpadSeven.Name = "NumpadSeven";
            this.NumpadSeven.Size = new System.Drawing.Size(80, 60);
            this.NumpadSeven.TabIndex = 1;
            this.NumpadSeven.Text = "7";
            this.NumpadSeven.UseVisualStyleBackColor = false;
            this.NumpadSeven.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadSix
            // 
            this.NumpadSix.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadSix.Location = new System.Drawing.Point(161, 343);
            this.NumpadSix.Name = "NumpadSix";
            this.NumpadSix.Size = new System.Drawing.Size(80, 60);
            this.NumpadSix.TabIndex = 1;
            this.NumpadSix.Text = "6";
            this.NumpadSix.UseVisualStyleBackColor = false;
            this.NumpadSix.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadFive
            // 
            this.NumpadFive.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadFive.Location = new System.Drawing.Point(81, 343);
            this.NumpadFive.Name = "NumpadFive";
            this.NumpadFive.Size = new System.Drawing.Size(80, 60);
            this.NumpadFive.TabIndex = 1;
            this.NumpadFive.Text = "5";
            this.NumpadFive.UseVisualStyleBackColor = false;
            this.NumpadFive.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadFour
            // 
            this.NumpadFour.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadFour.Location = new System.Drawing.Point(1, 343);
            this.NumpadFour.Name = "NumpadFour";
            this.NumpadFour.Size = new System.Drawing.Size(80, 60);
            this.NumpadFour.TabIndex = 1;
            this.NumpadFour.Text = "4";
            this.NumpadFour.UseVisualStyleBackColor = false;
            this.NumpadFour.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadThree
            // 
            this.NumpadThree.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadThree.Location = new System.Drawing.Point(161, 403);
            this.NumpadThree.Name = "NumpadThree";
            this.NumpadThree.Size = new System.Drawing.Size(80, 60);
            this.NumpadThree.TabIndex = 1;
            this.NumpadThree.Text = "3";
            this.NumpadThree.UseVisualStyleBackColor = false;
            this.NumpadThree.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadTwo
            // 
            this.NumpadTwo.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadTwo.Location = new System.Drawing.Point(81, 403);
            this.NumpadTwo.Name = "NumpadTwo";
            this.NumpadTwo.Size = new System.Drawing.Size(80, 60);
            this.NumpadTwo.TabIndex = 1;
            this.NumpadTwo.Text = "2";
            this.NumpadTwo.UseVisualStyleBackColor = false;
            this.NumpadTwo.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadOne
            // 
            this.NumpadOne.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadOne.Location = new System.Drawing.Point(1, 403);
            this.NumpadOne.Name = "NumpadOne";
            this.NumpadOne.Size = new System.Drawing.Size(80, 60);
            this.NumpadOne.TabIndex = 1;
            this.NumpadOne.Text = "1";
            this.NumpadOne.UseVisualStyleBackColor = false;
            this.NumpadOne.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // NumpadZero
            // 
            this.NumpadZero.BackColor = System.Drawing.SystemColors.Control;
            this.NumpadZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumpadZero.Location = new System.Drawing.Point(81, 463);
            this.NumpadZero.Name = "NumpadZero";
            this.NumpadZero.Size = new System.Drawing.Size(80, 60);
            this.NumpadZero.TabIndex = 1;
            this.NumpadZero.Text = "0";
            this.NumpadZero.UseVisualStyleBackColor = false;
            this.NumpadZero.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // LeftParenthesis
            // 
            this.LeftParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftParenthesis.Location = new System.Drawing.Point(81, 223);
            this.LeftParenthesis.Name = "LeftParenthesis";
            this.LeftParenthesis.Size = new System.Drawing.Size(80, 60);
            this.LeftParenthesis.TabIndex = 18;
            this.LeftParenthesis.Text = "(";
            this.LeftParenthesis.UseVisualStyleBackColor = true;
            // 
            // RightParenthesis
            // 
            this.RightParenthesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightParenthesis.Location = new System.Drawing.Point(161, 223);
            this.RightParenthesis.Name = "RightParenthesis";
            this.RightParenthesis.Size = new System.Drawing.Size(80, 60);
            this.RightParenthesis.TabIndex = 19;
            this.RightParenthesis.Text = ")";
            this.RightParenthesis.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 524);
            this.Controls.Add(this.RightParenthesis);
            this.Controls.Add(this.LeftParenthesis);
            this.Controls.Add(this.SquareRootButton1);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.DecimalPoint);
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
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private DecimalPointButton DecimalPoint;
        private EqualButton Equal;
        private SquareRootButton SquareRootButton1;
        private ParenthesisButton LeftParenthesis;
        private ParenthesisButton RightParenthesis;
    }
}

