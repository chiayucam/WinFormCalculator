using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 計算機抽象狀態
    /// </summary>
    public abstract class CalculatorState
    {
        /// <summary>
        /// 計算機Model Reference
        /// </summary>
        public virtual CalculatorModel Context { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機Model Reference</param>
        protected CalculatorState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        /// <summary>
        /// 運算子優先序字典
        /// </summary>
        public static readonly Dictionary<string, int> ArithmeticPrecedence = new Dictionary<string, int>
        {
            {"+", 1 },
            {"-", 1 },
            {"×", 2 },
            {"÷", 2 }
        };

        /// <summary>
        /// 運算方法字典
        /// </summary>
        public static readonly Dictionary<string, Func<string, string, string>> OperationDict = new Dictionary<string, Func<string, string, string>>
        {
            {"+", Operations.Add },
            {"-", Operations.Subtract },
            {"×", Operations.Multiply },
            {"÷", Operations.Divide }
        };

        /// <summary>
        /// 數字按鈕方法
        /// </summary>
        /// <param name="number">數字</param>
        public virtual void EnterNumber(string number)
        {
            Context.Operand = number;

            // 改變狀態
            if (number == "0")
            {
                Context.State = new StartState(Context);
            }
            else
            {
                Context.State = new AppendState(Context);
            }
        }

        /// <summary>
        /// 四則運算按鈕方法
        /// </summary>
        /// <param name="arithmetic">四則運算子</param>
        public virtual void EnterArithmetic(string arithmetic)
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(Context.Operand);
            Context.OperationHistory.Add(arithmetic);

            // 運算
            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            }

            Context.Result = Context.OperandStack.Peek();
            // TODO: change push operatorstack action to another place and make it push Context.Operator
            Context.OperatorStack.Push(arithmetic);
            Context.Operator = arithmetic;

            // 改變狀態
            // TODO: make states singleton and change to tenary operator
            if (Context.Result == Operations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new ComputedState(Context);
            }
        }

        /// <summary>
        /// 等號按鈕方法
        /// </summary>
        public virtual void EnterEqual()
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(Context.Operand);
            Context.OperationHistory.Add("=");

            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0)
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            }

            Context.Result = Context.OperandStack.Peek();
            Context.OperatorStack.Push(Context.Operator);

            // 改變狀態
            // TODO: make states singleton and change to tenary operator
            if (Context.Result == Operations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new EqualState(Context);
            }
        }

        /// <summary>
        /// 清除所有按鈕方法
        /// </summary>
        public virtual void EnterClearAll()
        {
            Context.ResetAll();
            Context.State = new StartState(Context);
        }

        /// <summary>
        /// 清除當前運算元方法
        /// </summary>
        public virtual void EnterClearEntry()
        {
            Context.ResetOperand();
            Context.State = new StartState(Context);
        }

        /// <summary>
        /// 退格按鈕方法
        /// </summary>
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

        /// <summary>
        /// 正負號按鈕方法
        /// </summary>
        public virtual void EnterSign()
        {
            Context.Operand = (-decimal.Parse(Context.Operand)).ToString();
        }

        /// <summary>
        /// 小數點按鈕方法
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public virtual void EnterDecimalPoint(string decimalPoint)
        {
            Context.Operand += decimalPoint;
            Context.State = new AppendDecimalState(Context);
        }

        /// <summary>
        /// 根號按鈕方法
        /// </summary>
        public virtual void EnterSquareRoot()
        {
            Context.OperationHistory.Add($"√( {Context.Operand} )");
            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
            Context.State = new UnaryOperatorState(Context);
        }
    }
}
