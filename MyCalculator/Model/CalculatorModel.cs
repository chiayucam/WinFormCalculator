using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 計算機Model
    /// </summary>
    public class CalculatorModel : ICalculatorModel
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public CalculatorModel()
        {
            State = new StartState(this);
            Operand = "0";
            Operator = "C";
            Result = "0";
            OperatorStack = new Stack<string>();
            OperandStack = new Stack<string>();
        }

        /// <summary>
        /// 計算機狀態
        /// </summary>
        public CalculatorState State { get; set; }

        /// <summary>
        /// 運算元state
        /// </summary>
        public string Operand { get; set; }

        /// <summary>
        /// 運算結果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 運算子
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 運算子堆疊
        /// </summary>
        public Stack<string> OperatorStack { get; set; }

        /// <summary>
        /// 運算元堆疊
        /// </summary>
        public Stack<string> OperandStack { get; set; }

        /// <summary>
        /// 設定運算元
        /// </summary>
        /// <param name="number">輸入運算元</param>
        /// <returns>運算元</returns>
        public string SetOperand(string number)
        {
            Operand = number;
            return Operand;
        }

        /// <summary>
        /// 重置運算元
        /// </summary>
        public void ResetOperand()
        {
            Operand = "0";
        }

        /// <summary>
        /// 重置運算子
        /// </summary>
        public void ResetOperator()
        {
            Operator = "C";
        }

        /// <summary>
        /// 重置所有
        /// </summary>
        public void ResetAll()
        {
            ResetOperand();
            ResetOperator();
            Result = "0";
            OperandStack.Clear();
            OperatorStack.Clear();
        }
    }
}
