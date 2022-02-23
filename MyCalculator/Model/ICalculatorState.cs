using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public interface ICalculatorState
    {
        char Operator { get; set; }
        decimal OperandOne { get; set; }
        decimal OperandTwo { get; set; }

        string AppendDigitToOperand(string digit);

        string Add(string value);

        void ResetAll();
    }
}
