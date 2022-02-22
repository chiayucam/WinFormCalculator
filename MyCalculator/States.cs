using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    /// <summary>
    /// 計算機狀態
    /// </summary>
    public static class States
    {
        /// <summary>
        /// 常數null字元
        /// </summary>
        public const char NULL_CHAR = '\0';

        /// <summary>
        /// 運算子，初始為null
        /// </summary>
        public static char Operator { get; set; } = NULL_CHAR;

        /// <summary>
        /// 運算元，初始為0.
        /// </summary>
        public static decimal Operand { get; set; } = 0m;

        /// <summary>
        /// 運算結果，初始為0.
        /// </summary>
        public static decimal Result { get; set; } = 0m;

        /// <summary>
        /// 運算元佇列(儲存二元運算)
        /// </summary>
        public static Queue<decimal> OperandQueue { get; set; } = new Queue<decimal>();

        /// <summary>
        /// 運算子堆疊
        /// </summary>
        public static Stack<char> OperatorStack { get; set; } = new Stack<char>();

        /// <summary>
        /// 上次按鈕點擊事件的型別
        /// </summary>
        public static Type LastButtonType { get; set; }

        /// <summary>
        /// 是否有小數點
        /// </summary>
        public static bool IsDecimalPointActive { get; set; } = false;

        /// <summary>
        /// 小數後位數
        /// </summary>
        public static int DecimalPointPositionCounter { get; set; } = 1;
        
        /// <summary>
        /// 重置運算子
        /// </summary>
        public static void ResetOperator()
        {
            Operator = NULL_CHAR;
        }

        /// <summary>
        /// 重置運算元
        /// </summary>
        public static void ResetOperand()
        {
            Operand = 0m;
            IsDecimalPointActive = false;
            DecimalPointPositionCounter = 1;
        }

        /// <summary>
        /// 重置運算結果
        /// </summary>
        public static void ResetResult()
        {
            Result = 0m;
        }

        /// <summary>
        /// 全部狀態重置
        /// </summary>
        public static void ResetAll()
        {
            ResetOperator();
            ResetOperand();
            ResetResult();
            States.OperandQueue.Clear();
            States.OperatorStack.Clear();
        }

        /// <summary>
        /// 運算式是否滿足條件: 2個運算元，1個四則運算子
        /// </summary>
        /// <returns></returns>
        public static bool IsOperationValid()
        {
            return States.OperandQueue.Count == 2 && States.OperatorStack.Count == 1;
        }
    }
}
