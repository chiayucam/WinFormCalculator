using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var calculatorState = new Model.CalculatorModel();
            var calculatorView = new View.CalculatorForm();
            var presenter = new Presenter.CalculatorPresenter(calculatorView, calculatorState);

            Application.Run(calculatorView);
        }
    }
}
