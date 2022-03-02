using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 運算方法
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="operandOne">左運算元</param>
        /// <param name="operandTwo">右運算元</param>
        /// <returns>運算結果</returns>
        public static string Add(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) + decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        /// <summary>
        /// 減法
        /// </summary>
        /// <param name="operandOne">左運算元</param>
        /// <param name="operandTwo">右運算元</param>
        /// <returns>運算結果</returns>
        public static string Subtract(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) - decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="operandOne">左運算元</param>
        /// <param name="operandTwo">右運算元</param>
        /// <returns>運算結果</returns>
        public static string Multiply(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) * decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="operandOne">左運算元</param>
        /// <param name="operandTwo">右運算元</param>
        /// <returns>運算結果</returns>
        public static string Divide(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string，DivideByZero例外處理放在外面做
            decimal newNumber = decimal.Parse(operandOne) / decimal.Parse(operandTwo);
            return newNumber.ToString();
        }
    }
}
