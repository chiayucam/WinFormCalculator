﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator.View
{
    /// <summary>
    /// 計算機Form
    /// </summary>
    internal partial class CalculatorForm : Form, ICalculatorView
    {
        /// <summary>
        /// 計算機Presenter reference
        /// </summary>
        public Presenter.CalculatorPresenter Presenter { get; set; }

        /// <summary>
        /// 下排顯示
        /// </summary>
        public string LowerLabel
        {
            get { return this.CurrentDisplay.Text; }
            set { this.CurrentDisplay.Text = value; }
        }

        /// <summary>
        /// 上排顯示
        /// </summary>
        public string UpperLabel
        {
            get { return this.OperationDisplay.Text; }
            set { this.OperationDisplay.Text = value; }
        }

        /// <summary>
        /// 初始化元件
        /// </summary>
        internal CalculatorForm()
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
            dynamic button = sender;
            Presenter.UpdateCalculatorView(button);
        }
    }
}
