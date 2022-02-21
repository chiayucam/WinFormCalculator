using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    /// <summary>
    /// 清除所有按鈕，繼承CalculatorButton
    /// </summary>
    internal class ClearAllButton : CalculatorButton
    {
        /// <summary>
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            States.ResetAll();
            currentDisplay.Text = GetTextForCurrentDisplay();
            operationDisplay.Text = GetTextForOperationDisplay();
        }

        /// <summary>
        /// 取得要在下排顯示的字串
        /// </summary>
        /// <returns>下排顯示的字串</returns>
        internal override string GetTextForCurrentDisplay()
        {
            return States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
        }

        /// <summary>
        /// 取得要在上排顯示的字串
        /// </summary>
        /// <returns>上排顯示的字串</returns>
        internal override string GetTextForOperationDisplay()
        {
            return string.Empty;
        }
    }
}
