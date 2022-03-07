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
        CalculatorState State { get;  set; }

        /// <summary>
        /// 運算元
        /// </summary>
        string Operand { get; set; }

        /// <summary>
        /// 運算結果
        /// </summary>
        string Result { get; set; }

        /// <summary>
        /// 運算子
        /// </summary>
        string Operator { get; set; }

        /// <summary>
        /// 運算過程紀錄
        /// </summary>
        List<string> OperationHistory { get; set; }

        /// <summary>
        /// 括號總數
        /// </summary>
        int ParenthesisBalance { get; set; }

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

        /// <summary>
        /// 重置所有
        /// </summary>
        void ResetAll();
    }
}
