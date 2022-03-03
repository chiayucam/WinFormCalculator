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
            // 更改運算紀錄
            Context.OperationHistory[0] = Context.Result;

            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0)
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                try
                {
                    Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
                }
                catch (DivideByZeroException)
                {
                    Context.OperandStack.Push("無法除以零");
                    Context.State = new ErrorState(Context);
                }
            }
            Context.Result = Context.OperandStack.Peek();
            Context.OperatorStack.Push(Context.Operator);
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
