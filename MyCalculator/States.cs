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
        public static char LastOperator = NULL_CHAR;
        public static decimal FirstOperand = 0m;
        public static decimal SecondOperand = 0m;
        public static decimal Result = 0m;
        public static string CurrentDisplay = string.Empty;
        public static string OperationDisplay = string.Empty;
        
        public static string GetTextForCurrentDisplay()
        {
            return FirstOperand.ToString(DECIMAL_TO_STRING_FORMAT);
        }
        
        public static string GetTextForOperationDisplay()
        {
            return Operator == NULL_CHAR ? string.Empty : $"{FirstOperand.ToString(DECIMAL_TO_STRING_FORMAT)} {Operator}";
        }

        public static void ResetOperator()
        {
            Operator = NULL_CHAR;
        }

        public static void ResetFirstOperand()
        {
            FirstOperand = 0m;
        }
        public static void ResetSecondOperand()
        {
            SecondOperand = 0m;
        }
        public static void ResetResult()
        {
            Result = 0m;
        }

        public static void ResetAll()
        {
            ResetOperator();
            ResetFirstOperand();
            ResetSecondOperand();
            ResetResult();
        }

        public static bool IsOperatorNull()
        {
            return Operator == NULL_CHAR;
        }


        public static void SetOperand(decimal number)
        {
            if (IsOperatorNull())
            {
                States.FirstOperand = States.FirstOperand * 10 + number;
            }
            else
            {
                States.SecondOperand = States.SecondOperand * 10 + number;
            }
        }
        public static void SetOperator(char _operator)
        {
            States.Operator = _operator;
        }

        



    }
}
