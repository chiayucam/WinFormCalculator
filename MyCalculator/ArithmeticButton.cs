using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    /// <summary>
    /// +, -, *, / 算數按鈕，繼承CalculatorButton
    /// </summary>
    internal class ArithmeticButton : CalculatorButton
    {
        /// <summary>
        /// 算數方法字典
        /// </summary>
        // TODO: 除以零例外處理
        private Dictionary<char, Func<decimal, decimal, decimal>> Operations = new Dictionary<char, Func<decimal, decimal, decimal>>()
        {
            {'+', (firstOperand, secondOperand) => firstOperand + secondOperand},
            {'-', (firstOperand, secondOperand) => firstOperand - secondOperand},
            {'×', (firstOperand, secondOperand) => firstOperand * secondOperand},
            {'÷', (firstOperand, secondOperand) => firstOperand / secondOperand}
        };

        /// <summary>
        /// 覆寫按鈕被點擊後呼叫的方法
        /// </summary>
        /// <param name="currentDisplay">下排顯示</param>
        /// <param name="operationDisplay">上排顯示</param>
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            // 傳入運算子
            States.Operator = char.Parse(Text);

            // 將運算元放入queue中
            States.OperandQueue.Enqueue(States.Operand);

            // 如運算式成立(queue有兩個運算元、stack有一個運算子)從Operations執行對應的運算並且清空queue、stack，如不成立複製運算元到Result等待顯示
            States.Result = States.IsOperationValid() ? Operations[States.OperatorStack.Pop()](States.OperandQueue.Dequeue(), States.OperandQueue.Dequeue()) : States.Operand;
            // TODO: 不知怎麼不用if 改成不用if
            if (States.OperandQueue.Count == 0) 
            {
                States.OperandQueue.Enqueue(States.Result);
            }
            States.OperatorStack.Push(States.Operator);

            // 顯示結果到display
            currentDisplay.Text = GetTextForCurrentDisplay();
            operationDisplay.Text = GetTextForOperationDisplay();
            States.ResetOperand();
        }
    }
}
