using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    class OperatorButton : CalculatorButton
    {
        public OperatorButton() : base()
        {

        }
        public override void Clicked()
        {
            States.Operator = char.Parse(Text);
        }
    }
}
