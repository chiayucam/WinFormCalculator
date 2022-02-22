using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    /// <summary>
    /// 計算機Form
    /// </summary>
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// 初始化元件
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按鈕事件
        /// </summary>
        /// <param name="sender">傳送的button物件</param>
        /// <param name="e">事件參數</param>
        private void CalculatorButtonOnClick(object sender, EventArgs e)
        {
            CalculatorButton button = (CalculatorButton)sender;
            button.Clicked(CurrentDisplay, OperationDisplay);
            States.LastButtonType = button.GetType();
        }
    }
}
