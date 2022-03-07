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
    public class UnaryOperatorState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public UnaryOperatorState(CalculatorModel calculatorModel) : base(calculatorModel)
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

            // 運算
            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            }

            Context.Result = Context.OperandStack.Peek();

            Context.OperatorStack.Push(arithmetic);
            Context.Operator = arithmetic;

            // 改變狀態
            if (Context.Result == ArithmeticOperations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new ComputedState(Context);
            }
        }

        /// <summary>
        /// 等號按鈕方法
        /// </summary>
        public override void EnterEqual()
        {
            // 加到運算紀錄裡
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
            if (Context.Result == ArithmeticOperations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new EqualState(Context);
            }
        }

        /// <summary>
        /// 退格鍵不做任何事
        /// </summary>
        public override void EnterBackSpace()
        {
        }

        /// <summary>
        /// 覆寫正負號按鈕方法
        /// </summary>
        public override void EnterSign()
        {
            string lastOperationHistory = Context.OperationHistory[Context.OperationHistory.Count - 1];
            Context.OperationHistory[Context.OperationHistory.Count - 1] = "negate( " + lastOperationHistory + " )";
            base.EnterSign();
        }

        /// <summary>
        /// 小數點按鈕方法
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public override void EnterDecimalPoint(string decimalPoint)
        {
            Context.OperationHistory.RemoveAt(Context.OperationHistory.Count - 1);
            Context.ResetOperand();
            base.EnterDecimalPoint(decimalPoint);
        }

        /// <summary>
        /// 將當前運算元開根號
        /// </summary>
        public override void EnterSquareRoot()
        {
            string lastOperationHistory = Context.OperationHistory[Context.OperationHistory.Count - 1];
            Context.OperationHistory[Context.OperationHistory.Count - 1] = "√( " + lastOperationHistory + " )";

            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
        }
    }
}
