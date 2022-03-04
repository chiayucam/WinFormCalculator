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
        /// <param name="calculatorModel">計算機Model reference</param>
        public CalculatorPresenter(ICalculatorView calculatorView, ICalculatorModel calculatorModel)
        {
            CalculatorModel = calculatorModel;
            CalculatorView = calculatorView;
            CalculatorView.Presenter = this;
        }

        /// <summary>
        /// 更新view，數字按鈕
        /// </summary>
        /// <param name="button">NumberButton型態的數字按鈕</param>
        internal void UpdateCalculatorView(NumberButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterNumber(button.Text);

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，四則運算子按鈕
        /// </summary>
        /// <param name="button">ArithmeticButton型態的四則運算子按鈕</param>
        internal void UpdateCalculatorView(ArithmeticButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterArithmetic(button.Text);

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Result;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，等號按鈕
        /// </summary>
        /// <param name="button">EqualButton型態的等號按鈕</param>
        internal void UpdateCalculatorView(EqualButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterEqual();

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Result;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，清除全部按鈕
        /// </summary>
        /// <param name="button">ClearAllButton型態的清除全部按鈕</param>
        internal void UpdateCalculatorView(ClearAllButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterClearAll();

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，清除輸入按鈕
        /// </summary>
        /// <param name="button">ClearEntryButton型態的清除輸入按鈕</param>
        internal void UpdateCalculatorView(ClearEntryButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterClearEntry();

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
        }

        /// <summary>
        /// 更新view，退格按鈕
        /// </summary>
        /// <param name="button">BackSpaceButton型態的退格按鈕</param>
        internal void UpdateCalculatorView(BackSpaceButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterBackSpace();

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，正負號按鈕
        /// </summary>
        /// <param name="button">SignButton型態的正負號按鈕</param>
        internal void UpdateCalculatorView(SignButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterSign();

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，小數點按鈕
        /// </summary>
        /// <param name="button">DecimalPointButton型態的小數點按鈕</param>
        internal void UpdateCalculatorView(DecimalPointButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterDecimalPoint(button.Text);

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }

        /// <summary>
        /// 更新view，根號按鈕
        /// </summary>
        /// <param name="button">SquareRootButton型態的根號按鈕</param>
        internal void UpdateCalculatorView(SquareRootButton button)
        {
            // 呼叫State方法
            CalculatorModel.State.EnterSquareRoot();

            // 顯示
            CalculatorView.LowerLabel = CalculatorModel.Operand;
            CalculatorView.UpperLabel = string.Join(" ", CalculatorModel.OperationHistory);
        }
    }
}
