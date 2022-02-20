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
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            States.SecondOperand = States.Result;
            decimal number = decimal.Parse(Text);
            //States.SetOperand(number);
            States.FirstOperand = States.FirstOperand * 10 + number;
            currentDisplay.Text = GetTextForCurrentDisplay();
        }

        internal override string GetTextForCurrentDisplay()
        {
            return States.FirstOperand.ToString(DECIMAL_TO_STRING_FORMAT);
        }

    }
}
