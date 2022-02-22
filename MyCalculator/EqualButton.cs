using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    /// <summary>
    /// 等號按鈕，繼承CalculatorButton
    /// </summary>
    internal class EqualButton : CalculatorButton
    {
        /// <summary>
        /// 運算子對應到運算方法的字典
        /// </summary>
        private Dictionary<char, Func<decimal, decimal, decimal>> Operations = new Dictionary<char, Func<decimal, decimal, decimal>>()
        {
            {'+', (firstOperand, secondOperand) => firstOperand + secondOperand},
            {'-', (firstOperand, secondOperand) => firstOperand - secondOperand},
            {'×', (firstOperand, secondOperand) => firstOperand * secondOperand},
            {'÷', (firstOperand, secondOperand) =>
                {
                    try
                    {
                        return firstOperand / secondOperand;
                    }
                    catch (DivideByZeroException)
                    {
                        return 0;
                    }
                }
            }
        };

        /// <summary>
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            // TODO: 重複點擊等號，相同操作
            // 傳入等號
            char equalChar = char.Parse(Text);
            decimal lastOperand = States.OperandQueue.Peek();
            // 將運算元放入queue中
            States.OperandQueue.Enqueue(States.Operand);
            // 如運算式成立(queue有兩個運算元、stack有一個運算子)從Operations執行對應的運算並且清空queue、stack，如不成立複製運算元到Result等待顯示
            States.Result = States.IsOperationValid() ? Operations[States.OperatorStack.Pop()](States.OperandQueue.Dequeue(), States.OperandQueue.Dequeue()) : States.Operand;

            // 顯示結果到display
            currentDisplay.Text = GetTextForCurrentDisplay();
            operationDisplay.Text = $"{lastOperand} {States.Operator} {States.Operand} = ";

            // TODO: 改成不用if
            if (States.OperandQueue.Count == 0)
            {
                States.Operand = States.Result;
            }
            States.ResetOperand();
        }

        /// <summary>
        /// 取得要在下排顯示的字串
        /// </summary>
        /// <returns>下排顯示的字串</returns>
        internal override string GetTextForCurrentDisplay()
        {
            return States.Result.ToString(DECIMAL_TO_STRING_FORMAT);
        }

        /// <summary>
        /// 取得要在上排顯示的字串
        /// </summary>
        /// <returns>上排顯示的字串</returns>
        internal override string GetTextForOperationDisplay()
        {
            return $"{States.Operand} {States.Operator} = {States.Result.ToString(DECIMAL_TO_STRING_FORMAT)} ";
        }
    }
}
