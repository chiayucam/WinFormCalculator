using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    class CalculatorButton : Button
    {
        public virtual void CallMessegeBox()
        {
            //MessageBox.Show(this.Text);
            Console.WriteLine(this.Text);
        }

        public virtual void Clicked()
        {

        }

        public virtual void Display()
        {

        }
    }
}
