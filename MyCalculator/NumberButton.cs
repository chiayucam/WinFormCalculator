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
            decimal number = decimal.Parse(Text);
            States.Operand = States.Operand >= 0 ? States.Operand * 10 + number : States.Operand * 10 - number;
            currentDisplay.Text = GetTextForCurrentDisplay();
        }

        internal override string GetTextForCurrentDisplay()
        {
            return States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
        }

    }
}
