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
    internal class CalculatorState : ICalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        internal CalculatorState()
        {
            Operand = string.Empty;
        }

        /// <summary>
        /// 常數decimal轉string格式字串
        /// </summary>
        private static readonly string DECIMAL_TO_STRING_FORMAT = "G12";

        /// <summary>
        /// 運算元state
        /// </summary>
        public string Operand { get; set; }

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
            Operand = string.Empty;
        }
    }
}
