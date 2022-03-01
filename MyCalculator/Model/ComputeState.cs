using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    class ComputeState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public ComputeState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public override void EnterNumber(string number)
        {
            Context.Operand = number;
            Context.State = new AppendState(Context);
        }

        public override void EnterArithmetic(string arithmetic)
        {
            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
            {
                string operandOne = Context.OperandStack.Pop();
                string operandTwo = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(Calculate(operandOne, operandTwo, _operator));
            }
            Context.Result = Context.OperandStack.Peek();
            Context.OperatorStack.Push(arithmetic);
            Context.Operand = string.Empty;
        }

        private string Calculate(string operandOne, string operandTwo, string _operator)
        {
            decimal result;
            if (_operator == "+")
            {
                result = decimal.Parse(operandOne) + decimal.Parse(operandTwo);
            }
            else if (_operator == "-")
            {
                result = decimal.Parse(operandOne) - decimal.Parse(operandTwo);
            }
            else if (_operator == "×")
            {
                result = decimal.Parse(operandOne) * decimal.Parse(operandTwo);
            }
            else
            {
                result = decimal.Parse(operandOne) / decimal.Parse(operandTwo);
            }
            return result.ToString();
        }

    }
}
