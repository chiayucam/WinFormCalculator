using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 根號狀態，繼承CalculatorState
    /// </summary>
    public class SquareRootState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public SquareRootState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 根據運算子進行運算
        /// </summary>
        /// <param name="arithmetic">運算子</param>
        public override void EnterArithmetic(string arithmetic)
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(arithmetic);

            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
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
            Context.OperatorStack.Push(arithmetic);
            Context.State = new ComputedState(Context);
        }

        /// <summary>
        /// 根據運算子堆疊進行運算，直到運算子堆疊清空，並轉換到ComputedState
        /// </summary>
        public override void EnterEqual()
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(Context.Operand);
            Context.OperationHistory.Add("=");

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
            Context.State = new ComputedState(Context);
        }

        /// <summary>
        /// 將當前運算元開根號
        /// </summary>
        public override void EnterSquareRoot()
        {
            Context.OperationHistory.Add($"√({Context.Operand})");
            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
            Context.State = new SquareRootState(Context);
        }
    }
}
