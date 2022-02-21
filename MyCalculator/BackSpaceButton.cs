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
            string operandString = States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
            operandString = operandString.Length == 1 ? "0" : operandString.Remove(operandString.Length - 1);
            States.Operand = decimal.Parse(operandString);
            currentDisplay.Text = GetTextForCurrentDisplay();
        }

        internal override string GetTextForCurrentDisplay()
        {
            return States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
        }
    }
}
