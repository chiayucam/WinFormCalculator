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

        public override void EnterEqual()
        {
            //Context.Operand = Context.Result;
            base.EnterEqual();
        }

        /// <summary>
        /// 覆寫退格按鈕方法，不做任何事
        /// </summary>
        public override void EnterBackSpace()
        {
        }

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
