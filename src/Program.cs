using System;
using System.IO;
using System.Windows.Forms;

namespace nlCryptoLatin
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
            // info.FullName就是临时目录的字符串
            string temp = System.Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            // 从网上找的资源文件写到路径代码
            string path = info.FullName;
            File.WriteAllBytes(path + "\\code.ini", System.Text.Encoding.Default.GetBytes(Properties.Resources.code));
            // 资源文件的code写到%temp%\code.ini
            Application.Run(new mainForm());
            // 启动主窗口
        }
    }
}
