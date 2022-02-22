using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    /// <summary>
    /// 計算機按鈕抽象類別
    /// </summary>
    internal abstract class CalculatorButton : Button
    {
        /// <summary>
        /// decimal到string轉換格式
        /// </summary>
        protected static readonly string DECIMAL_TO_STRING_FORMAT = "G9";

        /// <summary>
        /// 按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal abstract void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay);

        /// <summary>
        /// 取得要在下排顯示的Operand字串
        /// </summary>
        /// <returns>下排顯示的字串</returns>
        internal virtual string GetTextForCurrentDisplay()
        {
            return States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
        }

        /// <summary>
        /// 取得要在上排顯示的Operand字串與運算子
        /// </summary>
        /// <returns>上排顯示的字串</returns>
        internal virtual string GetTextForOperationDisplay()
        {
            return $"{States.Operand.ToString(DECIMAL_TO_STRING_FORMAT)} {States.Operator}";
        }
    }
}
