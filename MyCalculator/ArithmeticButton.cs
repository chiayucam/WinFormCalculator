using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class ArithmeticButton : OperatorButton
    {
        public override void Clicked()
        {
            States.Operator = char.Parse(Text);
        }
    }
}
