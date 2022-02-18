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
        public static decimal NewOperand = 0m;
        public static decimal CurrentOperand = 0m;
        
        public static string GetTextForCurrentDisplay()
        {
            return NewOperand.ToString(DECIMAL_TO_STRING_FORMAT);
        }
        
        public static string GetTextForOperationDisplay()
        {
            return Operator == NULL_CHAR ? string.Empty : $"{NewOperand.ToString(DECIMAL_TO_STRING_FORMAT)} {Operator.ToString()}";
        }

        public static void ResetOperator()
        {
            Operator = NULL_CHAR;
        }

        public static bool IsOperatorNull()
        {
            return Operator == NULL_CHAR;
        }
    }
}
