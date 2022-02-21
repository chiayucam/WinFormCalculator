using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    /// <summary>
    /// 0-9數字按鈕，繼承CalculatorButton
    /// </summary>
    class NumberButton : CalculatorButton
    {
        /// <summary>
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            //decimal number = decimal.Parse(Text);
            //States.Operand = States.Operand >= 0 ? States.Operand * 10 + number : States.Operand * 10 - number;
            //currentDisplay.Text = GetTextForCurrentDisplay();

            decimal number = decimal.Parse(Text);
            // TODO: 不知怎麼不用if 改成不用if
            if (States.IsDecimalPointActive)
            {
                States.Operand = States.Operand >= 0 ? States.Operand + number * (decimal)Math.Pow(0.1, States.DecimalPointPositionCounter) : States.Operand + number * (decimal)Math.Pow(0.1, States.DecimalPointPositionCounter);
                States.DecimalPointPositionCounter += 1;
            }
            else
            {
                States.Operand = States.Operand >= 0 ? States.Operand * 10 + number : States.Operand * 10 - number;
            }
            currentDisplay.Text = GetTextForCurrentDisplay();

            //States.Operand = decimal.Parse(States.Operand.ToString(DECIMAL_TO_STRING_FORMAT) + Text);
            //currentDisplay.Text = GetTextForCurrentDisplay();
        }

        /// <summary>
        /// 取得要在下排顯示的字串
        /// </summary>
        /// <returns>下排顯示的字串</returns>
        internal override string GetTextForCurrentDisplay()
        {
            return States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
        }
    }
}
