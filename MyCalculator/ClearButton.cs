using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    class ClearButton : CalculatorButton
    {
        public ClearButton() : base()
        {

        }
        public override void Clicked()
        {
            States.CurrentOperand = 0;
        }
    }
}
