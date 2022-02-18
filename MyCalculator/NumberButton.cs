using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    class NumberButton : CalculatorButton
    {
        public override void Clicked()
        {
            decimal value = decimal.Parse(Text);
            //MessageBox.Show("NumberButton");
            States.NewOperand = States.NewOperand * 10 + value;
            
        }

        public override void Display()
        {
            
        }
    }
}
