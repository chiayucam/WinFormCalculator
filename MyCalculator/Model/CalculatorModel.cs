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
        }

        public CalculatorState State { get; set; }

        /// <summary>
        /// 運算元state
        /// </summary>
        public string Operand { get; set; }

        public string Result { get; set; }

        public string Operator { get; set; }

        public Stack<string> OperatorStack = new Stack<string>();

        public Stack<string> OperandStack = new Stack<string>();

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

        public void ResetOperator()
        {
            Operator = "C";
        }

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
