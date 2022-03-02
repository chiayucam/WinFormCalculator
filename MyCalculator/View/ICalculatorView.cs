using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.View
{
    /// <summary>
    /// CalculatorView介面
    /// </summary>
    public interface ICalculatorView
    {
        /// <summary>
        /// 下排顯示
        /// </summary>
        string LowerLabel { get; set; }

        /// <summary>
        /// 上排顯示
        /// </summary>
        string UpperLabel { get; set; }

        /// <summary>
        /// Presenter reference
        /// </summary>
        Presenter.CalculatorPresenter Presenter { get; set; }
    }
}
