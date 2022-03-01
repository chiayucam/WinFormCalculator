using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    class AppendState : CalculatorState
    {
        public override CalculatorModel Context { get; set; }

        public AppendState(CalculatorModel calculatorModel)
        {
            Context = calculatorModel;
        }

        public override void EnterNumber(string number)
        {
            Context.Operand += number;
        }

        public override void EnterArithmetic(string arithmetic)
        {
            Context.OperandStack.Push(Context.Operand);
            Context.OperatorStack.Push(arithmetic);
            Context.Result = Context.Operand;
            Context.Operand = string.Empty;
            

            // 轉換狀態
            Context.State = new ComputeState(Context);
        }
    }
}
