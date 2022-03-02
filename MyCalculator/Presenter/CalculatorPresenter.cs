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
    public class CalculatorPresenter
    {
        /// <summary>
        /// 計算機View
        /// </summary>
        private ICalculatorView CalculatorView;

        /// <summary>
        /// 計算機Model
        /// </summary>
        private ICalculatorModel CalculatorModel;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="calculatorView">計算機View reference</param>
        /// <param name="calculatorState">計算機Model reference</param>
        internal CalculatorPresenter(ICalculatorView calculatorView, ICalculatorModel calculatorModel)
        {
            CalculatorModel = calculatorModel;
            CalculatorView = calculatorView;
            CalculatorView.Presenter = this;

            //CurrentOperand = ZERO_STRING;
            CurrentOperand = string.Empty;
            LastArithmeticOperator = 'C';
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
                { '+', (number) => CalculatorModel.Add(number) },
                { '-', (number) => CalculatorModel.Subtract(number) },
                { '×', (number) => CalculatorModel.Multiply(number) },
                { '÷', (number) => CalculatorModel.Divide(number) },
                { 'C', (number) => CalculatorModel.SetOperand(number) }
            };
        }

        /// <summary>
        /// 更新view，數字按鈕
        /// </summary>
        /// <param name="button">NumberButton型態的數字按鈕</param>
        internal void UpdateCalculatorView(NumberButton button)
        {
            CalculatorModel.State.EnterNumber(button.Text);

            CalculatorView.LowerLabel = CalculatorModel.Operand;

        }

        /// <summary>
        /// 更新view，四則運算子按鈕
        /// </summary>
        /// <param name="button">ArithmeticButton型態的四則運算子按鈕</param>
        internal void UpdateCalculatorView(ArithmeticButton button)
        {
            CalculatorView.UpperLabel += $"{CalculatorModel.Operand} {button.Text} ";

            CalculatorModel.State.EnterArithmetic(button.Text);

            string result = CalculatorModel.Result;
            
            CalculatorView.LowerLabel = result;
        }

        /// <summary>
        /// 更新view，等號按鈕
        /// </summary>
        /// <param name="button">EqualButton型態的等號按鈕</param>
        internal void UpdateCalculatorView(EqualButton button)
        {
            // 取得上一個運算元
            string lastOperand = CalculatorModel.Operand;
            
            try
            {
                decimal.Parse(CurrentOperand);
            }
            catch (FormatException)
            {
                CurrentOperand = lastOperand;
            }

            // 取得運算結果
            string result = Operations[LastArithmeticOperator](CurrentOperand);

            // 顯示上下排
            CalculatorView.UpperLabel = $"{lastOperand} {LastArithmeticOperator} {CurrentOperand} {button.Text}";
            CalculatorView.LowerLabel = result;
        }

        /// <summary>
        /// 更新view，清除全部按鈕
        /// </summary>
        /// <param name="button">AClearAllButton型態的清除全部按鈕</param>
        internal void UpdateCalculatorView(ClearAllButton button)
        {
            CalculatorModel.ResetOperand();

            LastArithmeticOperator = char.Parse(button.Text);
            //CurrentOperand = ZERO_STRING;
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
            //CurrentOperand = ZERO_STRING;
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
                // 測試數字部分(不含負號)字串長度，如 <=1 直接清空字串
                string negativeRemovedOperand = CurrentOperand.TrimStart('-');
                negativeRemovedOperand.Remove(negativeRemovedOperand.Length - 2);

                // 去除字串最後一個字元
                CurrentOperand = CurrentOperand.Remove(CurrentOperand.Length - 1);

                //顯示
                CalculatorView.LowerLabel = CurrentOperand;
            }
            catch (ArgumentOutOfRangeException)
            {
                // 清空運算元
                //CurrentOperand = ZERO_STRING;
                CurrentOperand = string.Empty;

                //顯示
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
