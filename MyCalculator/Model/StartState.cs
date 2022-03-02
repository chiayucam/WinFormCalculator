using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public class StartState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        internal StartState(CalculatorModel calculatorModel) : base(calculatorModel)
        {

        }

        public override void EnterNumber(string number)
        {
            if (number != "0")
            {
                Context.Operand = number;
                Context.State = new AppendState(Context);
            }
        }

        public override void EnterArithmetic(string arithmetic)
        {
            Context.State = new ComputedState(Context);
        }

        public override void EnterEqual()
        {
            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0)
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                try
                {
                    Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
                    Context.State = new ComputedState(Context);
                }
                catch (DivideByZeroException)
                {
                    Context.OperandStack.Push("無法除以零");
                    Context.State = new ErrorState(Context);
                }
            }
            Context.Result = Context.OperandStack.Peek();
        }

        public override void EnterClearEntry()
        {

        }

        public override void EnterSquareRoot()
        {
            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
        }
    }
}
