using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 錯誤狀態，繼承CalculatorState
    /// </summary>
    public class ErrorState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public ErrorState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 輸入數字不做任何事
        /// </summary>
        /// <param name="number">數字</param>
        public override void EnterNumber(string number)
        {
            Context.ResetAll();
            base.EnterNumber(number);
        }

        /// <summary>
        /// 輸入運算子不做任何事
        /// </summary>
        /// <param name="arithmetic">運算子</param>
        public override void EnterArithmetic(string arithmetic)
        {
        }

        /// <summary>
        /// 輸入等號不做任何事
        /// </summary>
        public override void EnterEqual()
        {
            Context.ResetAll();
            Context.State = new StartState(Context);
        }

        /// <summary>
        /// 輸入清除當前運算子不做任何事
        /// </summary>
        public override void EnterClearEntry()
        {
        }

        /// <summary>
        /// 輸入正負號不做任何事
        /// </summary>
        public override void EnterSign()
        {
        }

        /// <summary>
        /// 輸入小數點不做任何事
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public override void EnterDecimalPoint(string decimalPoint)
        {
        }

        /// <summary>
        /// 輸入根號不做任何事
        /// </summary>
        public override void EnterSquareRoot()
        {
        }
    }
}
