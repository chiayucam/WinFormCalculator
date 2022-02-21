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
            States.OperandQueue.Enqueue(States.FirstOperand);
            States.OperatorStack.Push(States.Operator);
            //States.ResetFirstOperand();
            States.Result = States.IsOperationValid() ? Operations[States.OperatorStack.Pop()](States.OperandQueue.Dequeue(), States.OperandQueue.Dequeue()) : States.FirstOperand;
            //States.OperandQueue.Enqueue(States.Result);
            
            //States.Result = Operations[States.Operator](States.FirstOperand, States.SecondOperand);
            currentDisplay.Text = GetTextForCurrentDisplay();
            operationDisplay.Text = GetTextForOperationDisplay();
            States.ResetFirstOperand();
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
