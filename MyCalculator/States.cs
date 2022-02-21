using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public static class States
    {
        public const string DECIMAL_TO_STRING_FORMAT = "G29";
        public const char NULL_CHAR = '\0';

        public static char Operator = NULL_CHAR;
        public static decimal Operand = 0m;
        public static decimal Result = 0m;

        public static Queue<decimal> OperandQueue = new Queue<decimal>();
        public static Stack<char> OperatorStack = new Stack<char>();

        public static Type LastButtonType;
        

        public static void ResetOperator()
        {
            Operator = NULL_CHAR;
        }

        public static void ResetOperand()
        {
            Operand = 0m;
        }

        public static void ResetResult()
        {
            Result = 0m;
        }

        public static void ResetAll()
        {
            ResetOperator();
            ResetOperand();
            ResetResult();
            States.OperandQueue.Clear();
            States.OperatorStack.Clear();
        }

        public static bool IsOperatorNull()
        {
            return Operator == NULL_CHAR;
        }

        public static bool IsOperationValid()
        {
            return States.OperandQueue.Count == 2 && States.OperatorStack.Count == 1;
        }

        





    }
}
