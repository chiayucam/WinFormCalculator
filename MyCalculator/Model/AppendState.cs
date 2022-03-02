using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    class AppendState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public AppendState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public override void EnterNumber(string number)
        {
            Context.Operand += number;
        }

        public override void EnterArithmetic(string arithmetic)
        {
            //Context.OperandStack.Push(Context.Operand);
            //Context.OperatorStack.Push(arithmetic);
            //Context.Result = Context.Operand;
            //Context.Operand = string.Empty;

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
            Console.WriteLine(Context.Result);

            Context.OperatorStack.Push(arithmetic);

            // 轉換狀態
            Context.State = new ComputedState(Context);
        }

        public static Dictionary<string, Func<string, string, string>> OperationDict = new Dictionary<string, Func<string, string, string>>
        {
            {"+", Operations.Add },
            {"-", Operations.Subtract },
            {"×", Operations.Multiply },
            {"÷", Operations.Divide }
        };
    }
}
