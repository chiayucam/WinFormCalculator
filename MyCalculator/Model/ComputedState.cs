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
        /// 將數字附加到運算元後，如輸入"0"進入StartState，如輸入"1~9"進入AppendState
        /// </summary>
        /// <param name="number">數字</param>
        public override void EnterNumber(string number)
        {
            Context.Operand = number;
            if (number == "0")
            {
                Context.State = new StartState(Context);
            }
            else
            {
                Context.State = new AppendState(Context);
            }
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
        /// 覆寫退格按鈕方法
        /// </summary>
        public override void EnterBackSpace()
        {
            // 不做任何事
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

        /// <summary>
        /// 將運算元取根號
        /// </summary>
        public override void EnterSquareRoot()
        {
            Context.OperationHistory.Add($"√({Context.Operand})");
            Context.Operand = Math.Sqrt(double.Parse(Context.Result)).ToString();
            Context.State = new SquareRootState(Context);
        }
    }
}
