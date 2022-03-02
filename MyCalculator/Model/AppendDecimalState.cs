﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 小數點數字附加狀態，繼承AppendState
    /// </summary>
    public class AppendDecimalState : AppendState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public AppendDecimalState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 覆寫小數點方法，不做任何事
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public override void EnterDecimalPoint(string decimalPoint)
        {
        }
    }
}
