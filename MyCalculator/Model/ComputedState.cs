using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 運算結束狀態，繼承CalculatorState
    /// </summary>
    public class ComputedState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public ComputedState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 輸入左括號重置運算元
        /// </summary>
        /// <param name="parenthesis">左括號</param>
        public override void EnterLeftParenthesis(string parenthesis)
        {
            Context.ResetOperand();
            base.EnterLeftParenthesis(parenthesis);
        }

        /// <summary>
        /// 覆寫右括號方法
        /// </summary>
        /// <param name="parenthesis">右括號</param>
        public override void EnterRightParenthesis(string parenthesis)
        {
            Context.Operand = Context.Result;
            base.EnterRightParenthesis(parenthesis);
        }

        /// <summary>
        /// 替換掉運算子
        /// </summary>
        /// <param name="arithmetic">運算子</param>
        public override void EnterArithmetic(string arithmetic)
        {
            // 替換掉運算子
            Context.OperatorStack.Pop();
            Context.OperatorStack.Push(arithmetic);

            // 更改運算紀錄
            Context.OperationHistory[Context.OperationHistory.Count - 1] = arithmetic;
        }

        /// <summary>
        /// 覆寫等號按鈕方法
        /// </summary>
        public override void EnterEqual()
        {
            base.EnterEqual();
        }

        /// <summary>
        /// 覆寫退格按鈕方法，不做任何事
        /// </summary>
        public override void EnterBackSpace()
        {
        }

        /// <summary>
        /// 覆寫正負號按鈕方法，顯示不同
        /// </summary>
        public override void EnterSign()
        {
            Context.OperationHistory.Add($"negate( {Context.Operand} )");
            base.EnterSign();
            Context.State = new UnaryOperatorState(Context);
        }

        /// <summary>
        /// 重置運算元後呼叫base method
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public override void EnterDecimalPoint(string decimalPoint)
        {
            Context.ResetOperand();
            base.EnterDecimalPoint(decimalPoint);
        }
    }
}
