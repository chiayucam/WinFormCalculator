using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    public static class Operations
    {
        public static string Add(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) + decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        public static string Subtract(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) - decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        public static string Multiply(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) * decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        public static string Divide(string operandOne, string operandTwo)
        {
            // 轉換成decimal做運算再轉回string
            decimal newNumber = decimal.Parse(operandOne) / decimal.Parse(operandTwo);
            return newNumber.ToString();
        }

        public static string SetOperand(string operandOne, string operandTwo)
        {
            return operandOne;
        }
    }
}
