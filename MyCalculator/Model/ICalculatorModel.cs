using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Model
{
    /// <summary>
    /// 計算機Model interface
    /// </summary>
    public interface ICalculatorModel
    {
        /// <summary>
        /// 計算機狀態模式
        /// </summary>
        CalculatorState State { get; set; }

        /// <summary>
        /// 運算元
        /// </summary>
        string Operand { get; set; }

        string Result { get; set; }

        string Operator { get; set; }

        /// <summary>
        /// 設定運算元
        /// </summary>
        /// <param name="number">輸入運算元</param>
        /// <returns>運算元</returns>
        string SetOperand(string number);

        /// <summary>
        /// 重置運算元
        /// </summary>
        void ResetOperand();

        void ResetAll();
    }
}
