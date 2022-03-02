using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    class AppendDecimalState : AppendState
    {
        public AppendDecimalState(CalculatorModel calculatorModel) : base(calculatorModel)
        {

        }

        public override void EnterDecimalPoint(string decimalPoint)
        {
            // 不做任何事
        }

    }
}
