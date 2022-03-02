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

        protected CalculatorState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public static readonly Dictionary<string, int> ArithmeticPrecedence = new Dictionary<string, int>
        {
            {"+", 1 },
            {"-", 1 },
            {"×", 2 },
            {"÷", 2 }
        };

        public static readonly Dictionary<string, Func<string, string, string>> OperationDict = new Dictionary<string, Func<string, string, string>>
        {
            {"+", Operations.Add },
            {"-", Operations.Subtract },
            {"×", Operations.Multiply },
            {"÷", Operations.Divide }
        };

        public abstract void EnterNumber(string number);

        public abstract void EnterArithmetic(string arithmetic);

        public abstract void EnterEqual();

        public virtual void EnterClearAll()
        {
            Context.ResetAll();
            Context.State = new StartState(Context);
        }

        public abstract void EnterClearEntry();

        public virtual void EnterBackSpace()
        {
            try
            {
                // 測試數字部分(不含負號)字串長度，如 <=1 直接清空字串
                string negativeRemovedOperand = Context.Operand.TrimStart('-');
                negativeRemovedOperand.Remove(negativeRemovedOperand.Length - 2);

                // 去除字串最後一個字元
                Context.Operand = Context.Operand.Remove(Context.Operand.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                // 清空運算元
                Context.ResetOperand();
                Context.State = new StartState(Context);
            }
        }

        public virtual void EnterSign()
        {
            Context.Operand = (-decimal.Parse(Context.Operand)).ToString();
        }

        public virtual void EnterDecimalPoint(string decimalPoint)
        {
            Context.Operand += decimalPoint;
            Context.State = new AppendDecimalState(Context);
        }

        public abstract void EnterSquareRoot();
    }
}
