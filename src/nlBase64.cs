
// 使用前请将code.ini放置到%temp%\code.ini中
// Code.ini得制作格式请参照项目里的code.ini(nlCryptoLatin使用的ini)

// 版本: nlb64b1

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace nlCoding
{
    internal class nlBase64
    {
        public string NlbEncode(string inText, bool longWordUsing)
        // inText是输入文本 loogWordUsing是是否使用长表
        {
            // info.FullName就是临时目录的字符串
            string temp = Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            // 定义使用的StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            // iniFile初始化
            iniFile ini = new iniFile(info.FullName + "\\code.ini");
            // b64的文本转到数组
            char[] b64textChar = inText.ToCharArray();
            // 用tempString做中继是为了小写字母双写方便
            Random rd = new Random();
            string tempString;
            // 随机数使用
            if (longWordUsing == true)
            // 如果使用长+短文本
            {
                for (int cycleNum = 0; cycleNum != inText.Length; cycleNum++)
                // 循环替换
                {
                    if (b64textChar[cycleNum] == '=')
                    // 由于辣鸡INI不支持文件名带= 所以要替换成'
                    {
                        tempString = "\'";
                    }
                    else
                    // 如果字符不是=
                    {
                        if (char.IsLower(b64textChar[cycleNum]))
                        // 由于辣鸡INI自动大小写兼容 所以小写字母要双写
                        {
                            tempString = b64textChar[cycleNum].ToString() + b64textChar[cycleNum].ToString();
                        }
                        else
                        // 莫得事就直接赋值力
                        {
                            tempString = b64textChar[cycleNum].ToString();
                        }
                    }
                    if (rd.Next(1, 4) == 1)
                    // 如果随机到了长文本(四分之一概率)
                    {
                        // 使用加密表A在字符串最后加上混淆文本
                        stringBuilder.Append(ini.ReadValue("enCodeB", tempString) + " ");
                    }
                    else
                    // 如果随机到了短文本(四分之三概率)
                    {
                        stringBuilder.Append(ini.ReadValue("enCodeA", tempString) + " ");
                    }
                }
            }
            else
            // 如果使用短文本
            {
                for (int cycleNum = 0; cycleNum != inText.Length; cycleNum++)
                {
                    if (b64textChar[cycleNum] == '=')
                    // 由于辣鸡INI不支持文件名带= 所以要替换成'
                    {
                        tempString = "\'";
                    }
                    else
                    // 如果字符不是=
                    {
                        if (char.IsLower(b64textChar[cycleNum]))
                        // 由于辣鸡INI自动大小写兼容 所以小写字母要双写
                        {
                            tempString = b64textChar[cycleNum].ToString() + b64textChar[cycleNum].ToString();
                        }
                        else
                        // 莫得事就直接赋值力
                        {
                            tempString = b64textChar[cycleNum].ToString();
                        }
                    }
                    // 使用加密表A在字符串最后加上混淆文本
                    stringBuilder.Append(ini.ReadValue("enCodeA", tempString) + " ");
                }
            }
            return stringBuilder.ToString();
        }
        public string nlbDecode(string inText)
        // inText为输入文本
        {
            // info.FullName就是临时目录的字符串
            string temp = Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            // iniFile初始化
            iniFile ini = new iniFile(info.FullName + "\\code.ini");
            // 定义使用的StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            // 辣鸡微软
            // 混淆的文本按词转到数组
            string[] b64textString = inText.Split(' ');
            for (int cycleNum = 0; cycleNum != b64textString.Length; cycleNum++)
            // 按照INI对应循环替换
            {
                string tempString = ini.ReadValue("deCode", b64textString[cycleNum].ToString());
                // 按照INI进行逐词替换
                if (tempString == "\'")
                {
                    stringBuilder.Append("=");
                }
                else
                {
                    stringBuilder.Append(tempString);
                }
            }
            return stringBuilder.ToString();
            // 返回解密结果
        }

        public 
    }

    public class iniFile
    // INI文件操作类
    {
        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private string sPath = null;
        public iniFile(string path)
        {
            sPath = path;
        }
        public void Writue(string section, string key, string value)
        {
            // section=配置节，key=键名，value=键值，path=路径
            WritePrivateProfileString(section, key, value, sPath);
        }
        public string ReadValue(string section, string key)
        {
            // 每次从ini中读取多少字节
            StringBuilder temp = new StringBuilder(255);
            // section=配置节，key=键名，temp=上面，path=路径
            GetPrivateProfileString(section, key, "", temp, 255, sPath);
            return temp.ToString();
        }

    }

}
