﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 計算機抽象狀態
    /// </summary>
    public abstract class CalculatorState
    {
        /// <summary>
        /// 計算機Model Reference
        /// </summary>
        public virtual CalculatorModel Context { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorModel">計算機Model Reference</param>
        protected CalculatorState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        /// <summary>
        /// 運算子優先序字典
        /// </summary>
        public static readonly Dictionary<string, int> ArithmeticPrecedence = new Dictionary<string, int>
        {
            {"+", 1 },
            {"-", 1 },
            {"×", 2 },
            {"÷", 2 },
            {"(", 0 }
        };

        /// <summary>
        /// 運算方法字典
        /// </summary>
        public static readonly Dictionary<string, Func<string, string, string>> OperationDict = new Dictionary<string, Func<string, string, string>>
        {
            {"+", ArithmeticOperations.Add },
            {"-", ArithmeticOperations.Subtract },
            {"×", ArithmeticOperations.Multiply },
            {"÷", ArithmeticOperations.Divide }
        };
        
        /// <summary>
        /// 數字按鈕方法
        /// </summary>
        /// <param name="number">數字</param>
        public virtual void EnterNumber(string number)
        {
            Context.Operand = number;

            // 改變狀態
            if (number == "0")
            {
                Context.State = new StartState(Context);
            }
            else
            {
                Context.State = new AppendState(Context);
            }
        }

        /// <summary>
        /// 左括號方法
        /// </summary>
        /// <param name="parenthesis">左括號</param>
        public virtual void EnterLeftParenthesis(string parenthesis)
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(parenthesis);

            // 總括號數量加一
            Context.ParenthesisBalance++;

            // 將括號加入OperatorStack
            Context.OperatorStack.Push(parenthesis);
        }

        /// <summary>
        /// 右括號方法
        /// </summary>
        /// <param name="parenthesis">右括號</param>
        public virtual void EnterRightParenthesis(string parenthesis)
        {
            Context.OperandStack.Push(Context.Operand);

            // 避免")" 比 "(" 多
            while (Context.ParenthesisBalance > 0)
            {
                // 加到運算紀錄裡
                Context.OperationHistory.Add(Context.Operand);
                Context.OperationHistory.Add(parenthesis);

                // 總括號數量減一
                Context.ParenthesisBalance--;

                // 運算
                while (Context.OperatorStack.Peek() != "(")
                {
                    string operandTwo = Context.OperandStack.Pop();
                    string operandOne = Context.OperandStack.Pop();
                    string _operator = Context.OperatorStack.Pop();
                    Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
                }

                Context.Result = Context.OperandStack.Peek();

                // 從OperatorStack移除 "("
                Context.OperatorStack.Pop();

                // 改變狀態
                if (Context.Result == ArithmeticOperations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
                {
                    Context.State = new ErrorState(Context);
                }
                else
                {
                    Context.State = new ParenthesisState(Context);
                }
                break;
            }
        }

        /// <summary>
        /// 四則運算按鈕方法
        /// </summary>
        /// <param name="arithmetic">四則運算子</param>
        public virtual void EnterArithmetic(string arithmetic)
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(Context.Operand);
            Context.OperationHistory.Add(arithmetic);

            // 運算
            Context.OperandStack.Push(Context.Operand);
            while (Context.OperatorStack.Count > 0 && ArithmeticPrecedence[arithmetic] <= ArithmeticPrecedence[Context.OperatorStack.Peek()])
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            }

            Context.Result = Context.OperandStack.Peek();

            Context.OperatorStack.Push(arithmetic);
            Context.Operator = arithmetic;

            // 改變狀態
            if (Context.Result == ArithmeticOperations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new ComputedState(Context);
            }
        }

        /// <summary>
        /// 等號按鈕方法
        /// </summary>
        public virtual void EnterEqual()
        {
            // 加到運算紀錄裡
            Context.OperationHistory.Add(Context.Operand);

            Context.OperandStack.Push(Context.Operand);

            // 把缺少的")"補上
            while (Context.ParenthesisBalance > 0)
            {
                // 加到運算紀錄裡
                Context.OperationHistory.Add(")");

                // 總括號數量減一
                Context.ParenthesisBalance--;

                // 運算
                while (Context.OperatorStack.Peek() != "(")
                {
                    string operandTwo = Context.OperandStack.Pop();
                    string operandOne = Context.OperandStack.Pop();
                    string _operator = Context.OperatorStack.Pop();
                    Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
                }

                Context.Result = Context.OperandStack.Peek();

                // 從OperatorStack移除 "("
                Context.OperatorStack.Pop();

                // 改變狀態
                if (Context.Result == ArithmeticOperations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
                {
                    Context.State = new ErrorState(Context);
                }
            }

            // 加到運算紀錄裡
            Context.OperationHistory.Add("=");

            // 運算沒有在括號內的數字
            while (Context.OperatorStack.Count > 0)
            {
                string operandTwo = Context.OperandStack.Pop();
                string operandOne = Context.OperandStack.Pop();
                string _operator = Context.OperatorStack.Pop();
                Context.OperandStack.Push(OperationDict[_operator](operandOne, operandTwo));
            }

            Context.Result = Context.OperandStack.Peek();
            Context.OperatorStack.Push(Context.Operator);

            // 改變狀態
            if (Context.Result == ArithmeticOperations.DIVIDE_BY_ZERO_ERROR_MESSAGE)
            {
                Context.State = new ErrorState(Context);
            }
            else
            {
                Context.State = new EqualState(Context);
            }
        }

        /// <summary>
        /// 清除所有按鈕方法
        /// </summary>
        public virtual void EnterClearAll()
        {
            Context.ResetAll();
            Context.State = new StartState(Context);
        }

        /// <summary>
        /// 清除當前運算元方法
        /// </summary>
        public virtual void EnterClearEntry()
        {
            Context.ResetOperand();
            Context.State = new StartState(Context);
        }

        /// <summary>
        /// 退格按鈕方法
        /// </summary>
        public virtual void EnterBackSpace()
        {
            try
            {
                // 測試數字部分(不含負號)字串長度，如 <=1 直接清空字串
                string negativeRemovedOperand = Context.Operand.TrimStart('-');
                negativeRemovedOperand.Remove(negativeRemovedOperand.Length - 2);

                // 去除字串最後一個字元
                Context.Operand = Context.Operand.Remove(Context.Operand.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                // 清空運算元
                Context.ResetOperand();
                Context.State = new StartState(Context);
            }
        }

        /// <summary>
        /// 正負號按鈕方法
        /// </summary>
        public virtual void EnterSign()
        {
            Context.Operand = (-decimal.Parse(Context.Operand)).ToString();
        }

        /// <summary>
        /// 小數點按鈕方法
        /// </summary>
        /// <param name="decimalPoint">小數點</param>
        public virtual void EnterDecimalPoint(string decimalPoint)
        {
            Context.Operand += decimalPoint;
            Context.State = new AppendDecimalState(Context);
        }

        /// <summary>
        /// 根號按鈕方法
        /// </summary>
        public virtual void EnterSquareRoot()
        {
            Context.OperationHistory.Add($"√( {Context.Operand} )");
            Context.Operand = Math.Sqrt(double.Parse(Context.Operand)).ToString();
            Context.State = new UnaryOperatorState(Context);
        }
    }
}
