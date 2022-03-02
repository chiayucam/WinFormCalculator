using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public class AppendState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public AppendState(CalculatorModel calculatorModel) : base(calculatorModel)
        {

        }

        public override void EnterNumber(string number)
        {
            Context.Operand += number;
        }

        public override void EnterArithmetic(string arithmetic)
        {
            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
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

            Context.OperatorStack.Push(arithmetic);

            // 轉換狀態
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
                }
                catch (DivideByZeroException)
                {
                    Context.OperandStack.Push("無法除以零");
                    Context.State = new ErrorState(Context);
                }
            }
            Context.Result = Context.OperandStack.Peek();
            Context.State = new ComputedState(Context);
        }

        public override void EnterClearEntry()
        {
            Context.ResetOperand();
            Context.State = new StartState(Context);
        }

        public override void EnterSquareRoot()
        {
            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
        }
    }
}
