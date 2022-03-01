using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public class StartState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        internal StartState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public override void EnterNumber(string number)
        {
            if (number == "0")
            {

            }
            else
            {
                Context.Operand = number;
                Context.State = new AppendState(Context);
            }
        }

        public override void EnterArithmetic(string arithmetic)
        {
            
            Context.State = new AppendState(Context);
        }
    }
}
