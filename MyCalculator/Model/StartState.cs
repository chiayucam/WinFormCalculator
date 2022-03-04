using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 初始狀態，繼承CalculatorState
    /// </summary>
    public class StartState : CalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機</param>
        public StartState(CalculatorModel calculatorModel) : base(calculatorModel)
        {
        }

        /// <summary>
        /// 根據運算子堆疊進行運算，直到運算子堆疊清空，並轉換到ComputedState
        /// </summary>
        public override void EnterEqual()
        {
            // TODO: Currently same as AppendState EnterEqual()
            //Context.OperandStack.Push(Context.Operand);
            //while (Context.OperatorStack.Count > 0)
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
            //Context.State = new EqualState(Context);

            base.EnterEqual();
        }

        /// <summary>
        /// 清除當前運算元按鈕，不做任何事
        /// </summary>
        public override void EnterClearEntry()
        {
        }

        /// <summary>
        /// 將當前運算元開根號
        /// </summary>
        public override void EnterSquareRoot()
        {
            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
        }
    }
}
