using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    /// <summary>
    /// +/-正負數按鈕，繼承CalculatorButton
    /// </summary>
    internal class SignButton : CalculatorButton
    {
        /// <summary>
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            States.Operand = -(States.Operand);
            currentDisplay.Text = GetTextForCurrentDisplay();
        }
    }
}
