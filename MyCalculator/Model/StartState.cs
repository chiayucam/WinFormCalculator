using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 初始狀態，繼承CalculatorState
    /// </summary>
    public class StartState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public StartState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 根據運算子堆疊進行運算，直到運算子堆疊清空，並轉換到ComputedState
        /// </summary>
        public override void EnterEqual()
        {
            base.EnterEqual();
            Context.State = new StartState(Context);
        }

        /// <summary>
        /// 清除當前運算元按鈕，不做任何事
        /// </summary>
        public override void EnterClearEntry()
        {
        }
    }
}
