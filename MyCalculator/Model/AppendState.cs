using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 數字附加狀態，繼承CalculatorState
    /// </summary>
    public class AppendState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public AppendState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 將數字附加到運算元後
        /// </summary>
        /// <param name="number">數字</param>
        public override void EnterNumber(string number)
        {
            Context.Operand += number;
        }
    }
}
