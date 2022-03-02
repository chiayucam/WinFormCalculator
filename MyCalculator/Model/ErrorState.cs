using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    class ErrorState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public ErrorState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public override void EnterNumber(string number)
        {

        }

        public override void EnterArithmetic(string arithmetic)
        {

        }
    }
}
