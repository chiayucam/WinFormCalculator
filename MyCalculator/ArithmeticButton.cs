using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class ArithmeticButton : OperatorButton
    {
        private Dictionary<char, Func<decimal, decimal, decimal>> Operations = new Dictionary<char, Func<decimal, decimal, decimal>>()
        {
            {'+', (firstOperand, secondOperand) => firstOperand + secondOperand},
            {'-', (firstOperand, secondOperand) => firstOperand - secondOperand},
            {'×', (firstOperand, secondOperand) => firstOperand * secondOperand},
            {'÷', (firstOperand, secondOperand) => firstOperand / secondOperand}
        };
        
        internal override void Clicked(CurrentDisplay currentDisplay, OperationDisplay operationDisplay)
        {
            
            States.Operator = char.Parse(Text);
            States.Result = Operations[States.Operator](States.FirstOperand, States.SecondOperand);
            currentDisplay.Text = GetTextForCurrentDisplay();
            operationDisplay.Text = GetTextForOperationDisplay();
            //States.ResetFirstOperand();
            States.LastOperator = States.Operator;
        }

        internal void UpdateDisplay()
        {

        }

        internal override string GetTextForCurrentDisplay()
        {
            return States.Result.ToString(DECIMAL_TO_STRING_FORMAT);
        }

        internal override string GetTextForOperationDisplay()
        {
            return $"{States.Result.ToString(DECIMAL_TO_STRING_FORMAT)} {States.Operator}";
        }

    }
}
