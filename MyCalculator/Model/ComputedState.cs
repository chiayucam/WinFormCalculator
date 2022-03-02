using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 運算結束狀態，繼承CalculatorState
    /// </summary>
    public class ComputedState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public ComputedState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 將數字附加到運算元後，如輸入"0"進入StartState，如輸入"1~9"進入AppendState
        /// </summary>
        /// <param name="number">數字</param>
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

        /// <summary>
        /// 替換掉運算子
        /// </summary>
        /// <param name="arithmetic">運算子</param>
        public override void EnterArithmetic(string arithmetic)
        {
            // 替換掉運算子
            Context.OperatorStack.Pop();
            Context.OperatorStack.Push(arithmetic);
        }

        /// <summary>
        /// 根據運算子堆疊進行運算，直到運算子堆疊清空
        /// </summary>
        public override void EnterEqual()
        {
            Context.OperandStack.Push(Context.Result);
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
            Context.OperatorStack.Push(Context.Operator);
        }

        /// <summary>
        /// 覆寫退格按鈕方法
        /// </summary>
        public override void EnterBackSpace()
        {
            // 不做任何事
        }

        /// <summary>
        /// 重置運算元後呼叫base method
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public override void EnterDecimalPoint(string decimalPoint)
        {
            Context.ResetOperand();
            base.EnterDecimalPoint(decimalPoint);
        }

        /// <summary>
        /// 將運算元取根號
        /// </summary>
        public override void EnterSquareRoot()
        {
            Context.Operand = Math.Sqrt(double.Parse(Context.Result)).ToString();
        }
    }
}
