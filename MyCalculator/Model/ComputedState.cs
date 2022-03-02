using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    class ComputedState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public ComputedState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public static Dictionary<string, Func<string, string, string>> OperationDict = new Dictionary<string, Func<string, string, string>>
        {
            {"+", Operations.Add },
            {"-", Operations.Subtract },
            {"×", Operations.Multiply },
            {"÷", Operations.Divide }
        };

        public override void EnterNumber(string number)
        {
            if (number == "0")
            {
                Context.State = new StartState(Context);
            }
            else
            {
                Context.Operand = number;
                Context.State = new AppendState(Context);
            }
        }

        public override void EnterArithmetic(string arithmetic)
        {
            //Context.OperandStack.Push(Context.Operand);
            //while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
            //{
            //    string operandTwo = Context.OperandStack.Pop();
            //    string operandOne = Context.OperandStack.Pop();
            //    string _operator = Context.OperatorStack.Pop();
            //    try
            //    {
            //        Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Context.OperandStack.Push("無法除以零");
            //        Context.State = new ErrorState(Context);
            //    }
            //}
            //Context.Result = Context.OperandStack.Peek();
            //Console.WriteLine(Context.Result);
            //Context.OperatorStack.Push(arithmetic);
            //Context.Operand = string.Empty;

            Context.OperatorStack.Pop();
            Context.OperatorStack.Push(arithmetic);
        }

        public string SetOperand(string operand)
        {
            Context.Operand = operand;
            return operand;
        }

        
    }
}
