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
        public abstract void EnterNumber(string number);

        /// <summary>
        /// 四則運算按鈕方法
        /// </summary>
        /// <param name="arithmetic">四則運算子</param>
        public abstract void EnterArithmetic(string arithmetic);

        /// <summary>
        /// 等號按鈕方法
        /// </summary>
        public abstract void EnterEqual();

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
        public abstract void EnterSquareRoot();
    }
}
