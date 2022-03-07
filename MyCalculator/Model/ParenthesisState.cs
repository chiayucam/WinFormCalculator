using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 括號狀態，繼承CalculatorState
    /// </summary>
    public class ParenthesisState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public ParenthesisState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 覆寫右括號方法，OperationHistory不同，少一個push to operandStack
        /// </summary>
        /// <param name="parenthesis">右括號</param>
        public override void EnterRightParenthesis(string parenthesis)
        {
            // 避免")" 比 "(" 多
            while (Context.ParenthesisBalance > 0)
            {
                // 加到運算紀錄裡
                Context.OperationHistory.Add(parenthesis);

                // 總括號數量減一
                Context.ParenthesisBalance--;

                // 運算
                while (Context.OperatorStack.Peek() != "(")
                {
                    string operandTwo = Context.OperandStack.Pop();
                    string operandOne = Context.OperandStack.Pop();
                    string _operator = Context.OperatorStack.Pop();
                    Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
                }

                Context.Result = Context.OperandStack.Peek();

                // 從OperatorStack移除 "("
                Context.OperatorStack.Pop();

                // 改變狀態
                if (Context.Result == Operations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
                {
                    Context.State = new ErrorState(Context);
                }
                break;
            }
        }

        /// <summary>
        /// 覆寫四則運算按鈕方法，顯示不同，少一個push to OperandStack
        /// </summary>
        /// <param name="arithmetic">四則運算子</param>
        public override void EnterArithmetic(string arithmetic)
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(arithmetic);

            // 運算
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
            if (Context.Result == Operations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
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
            if (Context.Result == Operations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new EqualState(Context);
            }
        }
    }
}
