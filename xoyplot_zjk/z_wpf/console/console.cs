﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace xoyplot_zjk.z_wpf.console
{
    class ConsoleHelper : TextWriter
    {
        private int maxRowLenght = 0;//textBox中显示的最大行数，若不限制，则置为0
        private TextBlock _textBox { set; get; }
        public ConsoleHelper(TextBlock txbx)
        {
            this._textBox = txbx;
            Console.SetOut(this);
        }

        public override void Write(string value)
        {
        //    if (_textBox.IsEnabled)
        //        Dispatcher.BeginInvoke(new ThreadStart(delegate ()
        //        {
        //            _textBox.Text = value;
        //        }), new object[0]);
        }




    public override void WriteLine(string value)
    {

    }

    public override Encoding Encoding//这里要注意,重写wirte必须也要重写编码类型
    {
        get { return Encoding.UTF8; }
    }

   }

}
