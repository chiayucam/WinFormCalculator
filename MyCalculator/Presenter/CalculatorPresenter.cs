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
    internal class CalculatorPresenter
    {
        private CalculatorForm CalculatorView;
        private ICalculatorState CalculatorState;

        private string CurrentValue;

        internal CalculatorPresenter(CalculatorForm calculatorView, ICalculatorState calculatorState)
        {
            CalculatorState = calculatorState;

            CalculatorView = calculatorView;
            CalculatorView.Presenter = this;
        }

        internal void UpdateCalculatorView(NumberButton button)
        {
            string newOperandString = CalculatorState.AppendDigitToOperand(button.Text);

            CalculatorView.LowerLabel = newOperandString;
        }

        internal void UpdateCalculatorView(ClearAllButton button)
        {
            CalculatorState.ResetAll();

            CalculatorView.UpperLabel = string.Empty;
            CalculatorView.LowerLabel = "0";
        }

        internal Dictionary<char, Func<string, string>> Operations;
        
        

        internal void UpdateCalculatorView(ArithmeticButton button)
        {
            
            //CalculatorState.Calculate
            CalculatorView.UpperLabel = string.Empty;
            CalculatorView.LowerLabel = "0";

            CalculatorState.Operator = char.Parse(button.Text);
        }

        // TODO: finish Operations
        private void InitiateOperations()
        {
            Operations = new Dictionary<char, Func<string, string>>
            {
                { '+', (value) => CalculatorState.Add(value) },
            };
        }

    }
}
