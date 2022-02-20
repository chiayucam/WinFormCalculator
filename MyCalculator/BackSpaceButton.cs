using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class BackSpaceButton : CalculatorButton
    {
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            States.ResetAll();
            currentDisplay.Text = GetTextForCurrentDisplay();
            operationDisplay.Text = GetTextForOperationDisplay();
        }

        internal override string GetTextForCurrentDisplay()
        {
            return States.FirstOperand.ToString(DECIMAL_TO_STRING_FORMAT);
        }

        internal override string GetTextForOperationDisplay()
        {
            return String.Empty;
        }
    }
}
