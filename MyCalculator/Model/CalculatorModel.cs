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
        }

        /// <summary>
        /// 常數decimal轉string格式字串
        /// </summary>
        private static readonly string DECIMAL_TO_STRING_FORMAT = "G12";

        public CalculatorState State { get; set; }

        /// <summary>
        /// 運算元state
        /// </summary>
        public string Operand { get; set; }

        public string Operator { get; set; }

        public string Result { get; set; }

        public Stack<string> OperatorStack = new Stack<string>();

        public Stack<string> OperandStack = new Stack<string>();

        /// <summary>
        /// 加法運算
        /// </summary>
        /// <param name="number">輸入運算元</param>
        /// <returns>加法運算結果</returns>
        public string Add(string number)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(Operand) + decimal.Parse(number);
            Operand = newNumber.ToString(DECIMAL_TO_STRING_FORMAT);
            return Operand;
        }

        /// <summary>
        /// 減法運算
        /// </summary>
        /// <param name="number">輸入運算元</param>
        /// <returns>減法運算結果</returns>
        public string Subtract(string number)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(Operand) - decimal.Parse(number);
            Operand = newNumber.ToString(DECIMAL_TO_STRING_FORMAT);
            return Operand;
        }

        /// <summary>
        /// 乘法運算
        /// </summary>
        /// <param name="number">輸入運算元</param>
        /// <returns>乘法運算結果</returns>
        public string Multiply(string number)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(Operand) * decimal.Parse(number);
            Operand = newNumber.ToString(DECIMAL_TO_STRING_FORMAT);
            return Operand;
        }

        /// <summary>
        /// 除法運算
        /// </summary>
        /// <param name="number">輸入運算元</param>
        /// <returns>除法運算結果</returns>
        public string Divide(string number)
        {
            // 例外處理: 除數為零
            try
            {
                decimal newNumber = decimal.Parse(Operand) / decimal.Parse(number);
                Operand = newNumber.ToString(DECIMAL_TO_STRING_FORMAT);
            }
            catch (DivideByZeroException)
            {
                Operand = string.Empty;
                return "無法除以零";
            }
            return Operand;
        }

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
            OperandStack.Clear();
            OperatorStack.Clear();
        }
    }
}
