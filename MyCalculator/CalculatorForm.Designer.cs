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
            
            this.CurrentDisplay = new System.Windows.Forms.Label();
            this.OperationDisplay = new System.Windows.Forms.Label();
            this.Numpad0 = new MyCalculator.NumberButton(0);
            this.Numpad1 = new MyCalculator.NumberButton(1);
            this.Numpad2 = new MyCalculator.NumberButton(2);
            this.Numpad3 = new MyCalculator.NumberButton(3);
            this.Numpad4 = new MyCalculator.NumberButton(4);
            this.Numpad5 = new MyCalculator.NumberButton(5);
            this.Numpad6 = new MyCalculator.NumberButton(6);
            this.Numpad7 = new MyCalculator.NumberButton(7);
            this.Numpad8 = new MyCalculator.NumberButton(8);
            this.Numpad9 = new MyCalculator.NumberButton(9);
            this.Sign = new System.Windows.Forms.Button();
            this.DecimalPoint = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentDisplay
            // 
            this.CurrentDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentDisplay.AutoEllipsis = true;
            this.CurrentDisplay.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDisplay.Location = new System.Drawing.Point(12, 50);
            this.CurrentDisplay.Name = "CurrentDisplay";
            this.CurrentDisplay.Size = new System.Drawing.Size(302, 74);
            this.CurrentDisplay.TabIndex = 0;
            this.CurrentDisplay.Text = "0";
            this.CurrentDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OperationDisplay
            // 
            this.OperationDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OperationDisplay.AutoEllipsis = true;
            this.OperationDisplay.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OperationDisplay.Location = new System.Drawing.Point(12, 9);
            this.OperationDisplay.Name = "OperationDisplay";
            this.OperationDisplay.Size = new System.Drawing.Size(285, 41);
            this.OperationDisplay.TabIndex = 0;
            this.OperationDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Numpad0
            // 
            this.Numpad0.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad0.Location = new System.Drawing.Point(89, 427);
            this.Numpad0.Name = "Numpad0";
            this.Numpad0.Size = new System.Drawing.Size(71, 69);
            this.Numpad0.TabIndex = 0;
            this.Numpad0.Text = "0";
            this.Numpad0.UseVisualStyleBackColor = true;
            this.Numpad0.Click += new System.EventHandler(this.CalculatorButtonOnClick);
            // 
            // Numpad1
            // 
            this.Numpad1.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad1.Location = new System.Drawing.Point(12, 352);
            this.Numpad1.Name = "Numpad1";
            this.Numpad1.Size = new System.Drawing.Size(71, 69);
            this.Numpad1.TabIndex = 0;
            this.Numpad1.Text = "1";
            this.Numpad1.UseVisualStyleBackColor = true;
            // 
            // Numpad2
            // 
            this.Numpad2.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad2.Location = new System.Drawing.Point(89, 352);
            this.Numpad2.Name = "Numpad2";
            this.Numpad2.Size = new System.Drawing.Size(71, 69);
            this.Numpad2.TabIndex = 0;
            this.Numpad2.Text = "2";
            this.Numpad2.UseVisualStyleBackColor = true;
            // 
            // Numpad3
            // 
            this.Numpad3.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad3.Location = new System.Drawing.Point(166, 352);
            this.Numpad3.Name = "Numpad3";
            this.Numpad3.Size = new System.Drawing.Size(71, 69);
            this.Numpad3.TabIndex = 0;
            this.Numpad3.Text = "3";
            this.Numpad3.UseVisualStyleBackColor = true;
            // 
            // Numpad4
            // 
            this.Numpad4.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad4.Location = new System.Drawing.Point(12, 277);
            this.Numpad4.Name = "Numpad4";
            this.Numpad4.Size = new System.Drawing.Size(71, 69);
            this.Numpad4.TabIndex = 0;
            this.Numpad4.Text = "4";
            this.Numpad4.UseVisualStyleBackColor = true;
            // 
            // Numpad5
            // 
            this.Numpad5.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad5.Location = new System.Drawing.Point(89, 277);
            this.Numpad5.Name = "Numpad5";
            this.Numpad5.Size = new System.Drawing.Size(71, 69);
            this.Numpad5.TabIndex = 0;
            this.Numpad5.Text = "5";
            this.Numpad5.UseVisualStyleBackColor = true;
            // 
            // Numpad6
            // 
            this.Numpad6.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad6.Location = new System.Drawing.Point(166, 277);
            this.Numpad6.Name = "Numpad6";
            this.Numpad6.Size = new System.Drawing.Size(71, 69);
            this.Numpad6.TabIndex = 0;
            this.Numpad6.Text = "6";
            this.Numpad6.UseVisualStyleBackColor = true;
            // 
            // Numpad7
            // 
            this.Numpad7.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad7.Location = new System.Drawing.Point(12, 202);
            this.Numpad7.Name = "Numpad7";
            this.Numpad7.Size = new System.Drawing.Size(71, 69);
            this.Numpad7.TabIndex = 0;
            this.Numpad7.Text = "7";
            this.Numpad7.UseVisualStyleBackColor = true;
            // 
            // Numpad8
            // 
            this.Numpad8.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad8.Location = new System.Drawing.Point(89, 202);
            this.Numpad8.Name = "Numpad8";
            this.Numpad8.Size = new System.Drawing.Size(71, 69);
            this.Numpad8.TabIndex = 0;
            this.Numpad8.Text = "8";
            this.Numpad8.UseVisualStyleBackColor = true;
            // 
            // Numpad9
            // 
            this.Numpad9.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numpad9.Location = new System.Drawing.Point(166, 202);
            this.Numpad9.Name = "Numpad9";
            this.Numpad9.Size = new System.Drawing.Size(71, 69);
            this.Numpad9.TabIndex = 0;
            this.Numpad9.Text = "9";
            this.Numpad9.UseVisualStyleBackColor = true;
            // 
            // Sign
            // 
            this.Sign.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sign.Location = new System.Drawing.Point(12, 427);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(71, 69);
            this.Sign.TabIndex = 0;
            this.Sign.Text = "+/-";
            this.Sign.UseVisualStyleBackColor = true;
            // 
            // DecimalPoint
            // 
            this.DecimalPoint.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DecimalPoint.Location = new System.Drawing.Point(166, 427);
            this.DecimalPoint.Name = "DecimalPoint";
            this.DecimalPoint.Size = new System.Drawing.Size(71, 69);
            this.DecimalPoint.TabIndex = 0;
            this.DecimalPoint.Text = ".";
            this.DecimalPoint.UseVisualStyleBackColor = true;
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Equal.Location = new System.Drawing.Point(243, 427);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(71, 69);
            this.Equal.TabIndex = 0;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Add.Location = new System.Drawing.Point(243, 352);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(71, 69);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Subtract.Location = new System.Drawing.Point(243, 277);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(71, 69);
            this.Subtract.TabIndex = 0;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Multiply.Location = new System.Drawing.Point(243, 202);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(71, 69);
            this.Multiply.TabIndex = 0;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Clear.Location = new System.Drawing.Point(89, 127);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(71, 69);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Backspace.Location = new System.Drawing.Point(166, 127);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(71, 69);
            this.Backspace.TabIndex = 0;
            this.Backspace.Text = "⌫";
            this.Backspace.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Divide.Location = new System.Drawing.Point(243, 127);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(71, 69);
            this.Divide.TabIndex = 0;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            // 
            // ClearEntry
            // 
            this.ClearEntry.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClearEntry.Location = new System.Drawing.Point(12, 127);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(71, 69);
            this.ClearEntry.TabIndex = 0;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 509);
            this.Controls.Add(this.OperationDisplay);
            this.Controls.Add(this.CurrentDisplay);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.Numpad7);
            this.Controls.Add(this.Numpad4);
            this.Controls.Add(this.Numpad1);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Numpad9);
            this.Controls.Add(this.Numpad6);
            this.Controls.Add(this.Numpad3);
            this.Controls.Add(this.DecimalPoint);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Numpad8);
            this.Controls.Add(this.Numpad5);
            this.Controls.Add(this.Numpad2);
            this.Controls.Add(this.Numpad0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.Text = "小算盤";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CurrentDisplay;
        private NumberButton Numpad0;
        private NumberButton Numpad1;
        private NumberButton Numpad2;
        private NumberButton Numpad3;
        private NumberButton Numpad4;
        private NumberButton Numpad5;
        private NumberButton Numpad6;
        private NumberButton Numpad7;
        private NumberButton Numpad8;
        private NumberButton Numpad9;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button DecimalPoint;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Label OperationDisplay;
    }
}

