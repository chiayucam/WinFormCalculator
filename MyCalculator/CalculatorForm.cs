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
    public partial class CalculatorForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private string OperandState;
        private string OperatorState;
        private string CurrentValueState;

        /// <summary>
        /// 按鈕事件
        /// </summary>
        /// <param name="sender">傳送的button物件</param>
        /// <param name="e"></param>
        private void CalculatorButtonOnClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            MessageBox.Show("23123");
            //sender.
        }


    }
}
