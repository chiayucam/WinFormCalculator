using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class CurrentDisplay : CalculatorDisplay
    {

        public void UpdateDisplay(string text)
        {
            Text = text;
        }

        public void UpdateDisplay(bool holder)
        {
        }
    }
}
