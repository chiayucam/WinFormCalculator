using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    /// <summary>
    /// 退格按鈕，繼承CalculatorButton
    /// </summary>
    internal class BackSpaceButton : CalculatorButton
    {
        /// <summary>
        /// 常數減號char
        /// </summary>
        private const char SUBSTRACT_CHAR = '-';

        /// <summary>
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            // TODO: 點擊運算子後不做動作，改成不用if
            if (States.LastButtonType != typeof(ArithmeticButton))
            {
                // 轉換成字串後去掉最後一字元
                string operandString = States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
                operandString = operandString.Length == 1 ? "0" : operandString.Remove(operandString.Length - 1);
                States.Operand = operandString.Length == 1 && operandString.First() == SUBSTRACT_CHAR ? 0m : decimal.Parse(operandString);

                // 顯示
                currentDisplay.Text = GetTextForCurrentDisplay();
            }
        }
    }
}
