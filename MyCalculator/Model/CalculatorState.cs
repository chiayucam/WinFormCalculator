using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    internal class CalculatorState : ICalculatorState
    {
        /// <summary>
        /// 建構子
        /// </summary>
        internal CalculatorState()
        {
            Operator = NULL_CHAR;
            OperandOne = 0m;
            OperandTwo = 0m;
            OperandString = string.Empty;
            IsDecimalPointActive = false;
            DecimalPointPositionCounter = 1;
        }

        /// <summary>
        /// 常數null字元
        /// </summary>
        public static readonly char NULL_CHAR = '\0';

        /// <summary>
        /// 運算子，初始為null
        /// </summary>
        public char Operator { get; set; }

        /// <summary>
        /// 運算元，初始為0.
        /// </summary>
        public decimal OperandOne { get; set; }

        /// <summary>
        /// 運算元，初始為0.
        /// </summary>
        public decimal OperandTwo { get; set; }

        public string OperandString { get; set; }

        /// <summary>
        /// 是否有小數點
        /// </summary>
        public  bool IsDecimalPointActive { get; set; }

        /// <summary>
        /// 小數後位數
        /// </summary>
        public int DecimalPointPositionCounter { get; set; }

        public string AppendDigitToOperand(string digit)
        {
            // 串接字串並更新運算元
            OperandString += digit;

            // 更新運算元
            //OperandOne = decimal.Parse(OperandStringOne);
            return OperandString;
        }

        /// <summary>
        /// 重置運算子
        /// </summary>
        public void ResetOperator()
        {
            Operator = NULL_CHAR;
        }

        /// <summary>
        /// 重置運算元
        /// </summary>
        public void ResetOperand()
        {
            OperandOne = 0m;
            OperandTwo = 0m;
            OperandString = string.Empty;
            IsDecimalPointActive = false;
            DecimalPointPositionCounter = 1;
        }

        /// <summary>
        /// 全部狀態重置
        /// </summary>
        public void ResetAll()
        {
            ResetOperator();
            ResetOperand();
        }

        public string Add(string value)
        {

            return value;
        }
    }
}
