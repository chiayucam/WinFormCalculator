using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public class ComputedState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public ComputedState(CalculatorModel calculatorModel) : base(calculatorModel)
        {

        }

        public override void EnterNumber(string number)
        {
            Context.Operand = number;
            if (number == "0")
            {
                Context.State = new StartState(Context);
            }
            else
            {
                Context.State = new AppendState(Context);
            }
        }

        public override void EnterArithmetic(string arithmetic)
        {
            // 替換掉運算子
            Context.OperatorStack.Pop();
            Context.OperatorStack.Push(arithmetic);
        }

        public override void EnterEqual()
        {
            Context.OperandStack.Push(Context.Result);
            while (Context.OperatorStack.Count > 0)
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();

                Console.WriteLine(operandOne, operandTwo, _operator);
                try
                {
                    Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
                }
                catch (DivideByZeroException)
                {
                    Context.OperandStack.Push("無法除以零");
                    Context.State = new ErrorState(Context);
                }
            }
            Context.Result = Context.OperandStack.Peek();
            Context.OperatorStack.Push(Context.Operator);

        }

        public override void EnterClearEntry()
        {
            Context.ResetOperand();
            Context.State = new StartState(Context);
        }

        public override void EnterBackSpace()
        {

        }

        public override void EnterDecimalPoint(string decimalPoint)
        {
            Context.ResetOperand();
            Context.Operand += decimalPoint;
            Context.State = new AppendDecimalState(Context);
        }

        public override void EnterSquareRoot()
        {
            Context.Operand = Math.Sqrt(double.Parse(Context.Result)).ToString();
        }

        public string SetOperand(string operand)
        {
            Context.Operand = operand;
            return operand;
        }

        
    }
}
