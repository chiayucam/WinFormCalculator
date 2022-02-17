using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public class NumberButton : Button
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public NumberButton(int value)
        {
            Value = value;
        }

        public int Value;

        /// <summary>
        /// 
        /// </summary>
        private void OnButtonClick()
        {
            //GetOperandState();
        }

    }
}