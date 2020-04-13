using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Clipboard = System.Windows.Forms.Clipboard;
using DataFormats = System.Windows.Forms.DataFormats;
using IDataObject = System.Windows.Forms.IDataObject;

namespace nlCryptoLatin
{
public partial class mainForm : Form
{
    public mainForm()
    {
        InitializeComponent();
    }

    private void enCode_Click(object sender, EventArgs e)
    {
        MD5 md5 = MD5.Create();
        string b64text;
        if (useCrypto.Checked == true)
            // 如果使用加密
        {
            byte[] encryptionBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(passwordText.Text));
            string EncryptionStr = Convert.ToBase64String(encryptionBytes);
            // 密码进行MD5之后取前十六位用于AES加密
            b64text = AesClass.AesEncrypt(ioText.Text, EncryptionStr.Substring(0, 16));
            // 密码和文本进行AES-ECB加密再进行BASE64
        } else {
            // 如果不使用加密
            byte[] inArray = Encoding.Default.GetBytes(ioText.Text);
            b64text = Convert.ToBase64String(inArray);
            // 直接BASE64输入框文本
        }

        // 加密后的文本进行nlb64混淆
        ioText.Text = nlBase64.NlbEncode(b64text, useLongWord.Checked);
        // 放到剪辑版
        if (useClipBoard.Checked == true) {
            Clipboard.SetDataObject(ioText.Text);
        }
    }

    private void deCode_Click(object sender, EventArgs e)
    {
        MD5 md5 = MD5.Create();
        // 去首尾空及换行
        string trimText = ioText.Text.Trim();
        trimText = trimText.Replace("\r", "");
        trimText = trimText.Replace("\n", "");
        // ioText.Text = nlBase64.nlbDecode(ioText.Text);
        if (useCrypto.Checked == true)
            // 如果使用解密
        {
            byte[] encryptionBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(passwordText.Text));
            string EncryptionStr = Convert.ToBase64String(encryptionBytes);
            // 密码进行MD5之后取前十六位用于AES解密
            ioText.Text = AesClass.AesDecrypt(nlBase64.nlbDecode(trimText), EncryptionStr.Substring(0, 16));
        } else {
            ioText.Text = Encoding.Default.GetString(Convert.FromBase64String(nlBase64.nlbDecode(trimText)));
            // 直接输出
        }

    }

    private void clear_Click(object sender, EventArgs e)
    {
        ioText.Text = "";
    }

    private void about_DoubleClick(object sender, EventArgs e)
    {
        string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
        if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW") {
            MessageBox.Show("作者:慕华 版本:latin4v3 发布时间: 2020年4月12日 作者邮箱:usnnrqffjcqv@protonmail.com 许可证:GPLv3 需要源码请联系作者邮箱");
        } else {
            MessageBox.Show("Author:Muhua Version:latin4v3 ReleaseTime:2020/4/12 AuthonE-mail:usnnrqffjcqv@protonmail.com License:GPLv3 For source code, please contact the author's email.");
        }

    }

    private void mainForm_Load(object sender, EventArgs e)
    {
        string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
        if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW") {
            // 手动汉化，因为用resx汉化会出多个文件，不好发布
            about.Text = "作者：慕华" + Environment.NewLine + "版本：latin4v3" + Environment.NewLine + "双击查看更多";
            enCode.Text = "编码";
            deCode.Text = "解码";
            clear.Text = "清空";
            useClipBoard.Text = "使用剪辑版";
            useCrypto.Text = "使用加密";
            useLongWord.Text = "使用长表";
        }
    }

    private void mainForm_Activated(object sender, EventArgs e)
    {
        // 剪辑版处理
        if (useClipBoard.Checked == true) {
            IDataObject iData = Clipboard.GetDataObject();
            ioText.Text = (string)iData.GetData(DataFormats.Text);
        }
    }
}
}
