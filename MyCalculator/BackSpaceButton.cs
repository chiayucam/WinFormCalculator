﻿using System;
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
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            // TODO: 點擊運算子後不做動作
            string operandString = States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
            operandString = operandString.Length == 1 ? "0" : operandString.Remove(operandString.Length - 1);
            States.Operand = decimal.Parse(operandString);
            currentDisplay.Text = GetTextForCurrentDisplay();
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
