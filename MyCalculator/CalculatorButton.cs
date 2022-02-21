using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    internal abstract class CalculatorButton : Button
    {
        protected const string DECIMAL_TO_STRING_FORMAT = "G29";

        internal virtual void CallMessegeBox()
        {
            Console.WriteLine(this.Text);
        }

        internal abstract void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay);

        internal virtual string GetTextForCurrentDisplay()
        {
            return States.Operand.ToString(DECIMAL_TO_STRING_FORMAT);
        }

        internal virtual string GetTextForOperationDisplay()
        {
            return $"{States.Operand.ToString(DECIMAL_TO_STRING_FORMAT)} {States.Operator}";
        }
    }
}
