using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public interface ICalculatorState
    {
        string Operand { get; set; }

        string Add(string value);

        string Subtract(string value);

        string Multiply(string value);

        string Divide(string value);

        string SetOperand(string value);

        void ResetOperand();
    }
}
