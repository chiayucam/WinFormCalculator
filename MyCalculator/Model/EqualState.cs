using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 等號狀態，繼承CalculatorState
    /// </summary>
    public class EqualState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public EqualState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        public override void EnterNumber(string number)
        {
            Context.ResetAll();
            base.EnterNumber(number);
        }

        /// <summary>
        /// 根據運算子進行運算
        /// </summary>
        /// <param name="arithmetic">運算子</param>
        public override void EnterArithmetic(string arithmetic)
        {
            Context.OperationHistory.Clear();
            Context.Operand = Context.Result;

            base.EnterArithmetic(arithmetic);
        }

        /// <summary>
        /// 根據運算子堆疊進行運算，直到運算子堆疊清空
        /// </summary>
        public override void EnterEqual()
        {
            // TODO: 0= = = = = problem
            // 更改運算紀錄，清除前面紀錄只顯示兩個運算元及一個運算子
            Context.OperationHistory.Clear();
            Context.OperationHistory.Add(Context.Result);
            Context.OperationHistory.Add(Context.Operator);
            Context.OperationHistory.Add(Context.Operand);
            Context.OperationHistory.Add("=");

            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0)
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            }

            Context.Result = Context.OperandStack.Peek();
            Context.OperatorStack.Push(Context.Operator);

            // 改變狀態
            // TODO: make states singleton and change to tenary operator
            if (Context.Result == Operations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
        }

        /// <summary>
        /// 退格按鈕方法
        /// </summary>
        public override void EnterBackSpace()
        {
            Context.OperationHistory.Clear();
            Context.Operand = Context.Result;
        }

        /// <summary>
        /// 小數點按鈕方法
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public override void EnterDecimalPoint(string decimalPoint)
        {
            Context.ResetAll();
            base.EnterDecimalPoint(decimalPoint);
        }

        /// <summary>
        /// 將當前運算元開根號
        /// </summary>
        public override void EnterSquareRoot()
        {
            Context.Operand = Context.Result;
            Context.OperationHistory.Clear();
            base.EnterSquareRoot();
        }
    }
}
