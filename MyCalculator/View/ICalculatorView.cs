using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.View
{
    public interface ICalculatorView
    {
        string LowerLabel { get; set; }

        string UpperLabel { get; set; }

        Presenter.CalculatorPresenter Presenter { get; set; }
    }
}
