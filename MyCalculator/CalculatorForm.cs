using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按鈕事件
        /// </summary>
        /// <param name="sender">傳送的button物件</param>
        /// <param name="e"></param>
        private void CalculatorButtonOnClick(object sender, EventArgs e)
        {
            CalculatorButton button = (CalculatorButton)sender; // what to cast?
            button.Clicked(CurrentDisplay, OperationDisplay);
            //CurrentDisplay.UpdateDisplay(button.GetTextForCurrentDisplay());
            //OperationDisplay.UpdateDisplay(button.GetTextForOperationDisplay());
            Console.WriteLine($"{States.FirstOperand} {States.Operator} {States.SecondOperand} = {States.Result}");
            //States.ResetNewOperand();
            //CurrentDisplay.Update(button);
        }
    }
}
