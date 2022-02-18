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
            decimal tempValue = 0;
            //MessageBox.Show("NumberButton");
            //States.IsOperatorNull() ? 
            States.NewOperand = States.NewOperand * 10 + value;


        }

        public override void Display()
        {
            
        }
    }
}
