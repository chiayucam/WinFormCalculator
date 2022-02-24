using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;
using MyCalculator.View;
using MyCalculator.Model;

namespace MyCalculator.Presenter
{
    /// <summary>
    /// 計算機Presenter
    /// </summary>
    internal class CalculatorPresenter
    {
        /// <summary>
        /// 計算機View
        /// </summary>
        private CalculatorForm CalculatorView;

        /// <summary>
        /// 計算機Model
        /// </summary>
        private ICalculatorState CalculatorState;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorView">計算機View reference</param>
        /// <param name="calculatorState">計算機Model reference</param>
        internal CalculatorPresenter(CalculatorForm calculatorView, ICalculatorState calculatorState)
        {
            CalculatorState = calculatorState;
            CalculatorView = calculatorView;
            CalculatorView.Presenter = this;

            CurrentOperand = string.Empty;
            LastArithmeticOperator = '\0';
            InitiateOperations();
        }

        /// <summary>
        /// 數字零常數字串
        /// </summary>
        private static readonly string ZERO_STRING = "0";

        /// <summary>
        /// 當前輸入運算元
        /// </summary>
        private string CurrentOperand;

        /// <summary>
        /// 上個輸入四則運算子
        /// </summary>
        private char LastArithmeticOperator;

        /// <summary>
        /// 字元與四則運算對照字典
        /// </summary>
        private Dictionary<char, Func<string, string>> Operations;

        /// <summary>
        /// 初始化字元與四則運算對照字典
        /// </summary>
        private void InitiateOperations()
        {
            Operations = new Dictionary<char, Func<string, string>>
            {
                { '+', (value) => CalculatorState.Add(value) },
                { '-', (value) => CalculatorState.Subtract(value) },
                { '×', (value) => CalculatorState.Multiply(value) },
                { '÷', (value) => CalculatorState.Divide(value) },
                { '\0', (value) => CalculatorState.SetOperand(value) }
            };
        }

        /// <summary>
        /// 更新view，數字按鈕
        /// </summary>
        /// <param name="button">NumberButton型態的數字按鈕</param>
        internal void UpdateCalculatorView(NumberButton button)
        {
            // 將新數字串接再運算元字串後
            CurrentOperand += button.Text;

            // 顯示新字串
            CalculatorView.LowerLabel = CurrentOperand;
        }

        /// <summary>
        /// 更新view，四則運算子按鈕
        /// </summary>
        /// <param name="button">ArithmeticButton型態的四則運算子按鈕</param>
        internal void UpdateCalculatorView(ArithmeticButton button)
        {
            string result = Operations[LastArithmeticOperator](CurrentOperand);

            CalculatorView.UpperLabel = $"{result} {button.Text}";
            CalculatorView.LowerLabel = result;

            LastArithmeticOperator = char.Parse(button.Text);
            CurrentOperand = string.Empty;
        }

        /// <summary>
        /// 更新view，等號按鈕
        /// </summary>
        /// <param name="button">EqualButton型態的等號按鈕</param>
        internal void UpdateCalculatorView(EqualButton button)
        {
            string lastOperand = CalculatorState.Operand;
            string result = Operations[LastArithmeticOperator](CurrentOperand);

            CalculatorView.UpperLabel = $"{lastOperand} {LastArithmeticOperator} {CurrentOperand} {button.Text}";
            CalculatorView.LowerLabel = result;
        }

        /// <summary>
        /// 更新view，清除全部按鈕
        /// </summary>
        /// <param name="button">AClearAllButton型態的清除全部按鈕</param>
        internal void UpdateCalculatorView(ClearAllButton button)
        {
            CalculatorState.ResetOperand();

            LastArithmeticOperator = '\0';
            CurrentOperand = string.Empty;

            CalculatorView.UpperLabel = string.Empty;
            CalculatorView.LowerLabel = ZERO_STRING;
        }

        /// <summary>
        /// 更新view，清除輸入按鈕
        /// </summary>
        /// <param name="button">ClearEntryButton型態的清除輸入按鈕</param>
        internal void UpdateCalculatorView(ClearEntryButton button)
        {
            CurrentOperand = string.Empty;

            CalculatorView.LowerLabel = ZERO_STRING;
        }

        /// <summary>
        /// 更新view，退格按鈕
        /// </summary>
        /// <param name="button">BackSpaceButton型態的退格按鈕</param>
        internal void UpdateCalculatorView(BackSpaceButton button)
        {
            try
            {
                CurrentOperand.Remove(CurrentOperand.Length - 2);
                CurrentOperand = CurrentOperand.Remove(CurrentOperand.Length - 1);

                CalculatorView.LowerLabel = CurrentOperand;
            }
            catch (ArgumentOutOfRangeException)
            {
                CalculatorView.LowerLabel = ZERO_STRING;
            }
        }

        /// <summary>
        /// 更新view，正負號按鈕
        /// </summary>
        /// <param name="button">SignButton型態的正負號按鈕</param>
        internal void UpdateCalculatorView(SignButton button)
        {
            // 例外處理 CurrentOperand為空字串
            try
            {
                CurrentOperand = (-decimal.Parse(CurrentOperand)).ToString();
                CalculatorView.LowerLabel = CurrentOperand;
            }
            catch (FormatException)
            {
                // 不對CurrentOperand做變更
            }
        }

        /// <summary>
        /// 更新view，小數點按鈕
        /// </summary>
        /// <param name="button">DecimalPointButton型態的小數點按鈕</param>
        internal void UpdateCalculatorView(DecimalPointButton button)
        {
            try
            {
                CurrentOperand += ".";
                decimal.Parse(CurrentOperand);
                CalculatorView.LowerLabel = CurrentOperand;
            }
            catch (FormatException)
            {
                CurrentOperand = CurrentOperand.Remove(CurrentOperand.Length - 1);
                CalculatorView.LowerLabel = CurrentOperand;
            } 
        }
    }
}
