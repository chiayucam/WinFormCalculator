using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public abstract class CalculatorState
    {
        public abstract CalculatorModel Context { get; set; }

        public static readonly Dictionary<string, int> ArithmeticPrecedence = new Dictionary<string, int>
        {
            {"+", 1 },
            {"-", 1 },
            {"×", 2 },
            {"÷", 2 }
        };

        public abstract void EnterNumber(string number);

        public abstract void EnterArithmetic(string arithmetic);
    }
}
