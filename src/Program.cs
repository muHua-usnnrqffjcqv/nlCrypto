﻿using System;
using System.IO;
using System.Windows.Forms;

namespace nlCrypto
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
            // 启动主窗口
        }
    }
}
