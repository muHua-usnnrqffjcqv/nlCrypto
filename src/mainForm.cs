﻿using System;
using System.IO;
using System.Windows.Forms;
using Clipboard = System.Windows.Forms.Clipboard;

namespace nlCrypto
{
    public partial class mainForm : Form
    {

        string privateKey;
        string publicKey;
        public mainForm()
        {
            InitializeComponent();
        }
        private void enCode_Click(object sender, EventArgs e)
        {
            ioText.Text=nlc.encode(ioText.Text, passwordText.Text, useCrypto.Checked, useLongWord.Checked);
            if (useClipBoard.Checked==true) 
            {
                Clipboard.SetText(ioText.Text);
            }
        }
        private void deCode_Click(object sender, EventArgs e)
        {
            ioText.Text = nlc.decode(ioText.Text,passwordText.Text,useCrypto.Checked);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            ioText.Text = "";
        }
        private void about_DoubleClick(object sender, EventArgs e)
        {
            string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
            {
                MessageBox.Show("作者:慕华 版本:latin5v1 发布时间: 2020年4月21日 作者邮箱:usnnrqffjcqv@protonmail.com 许可证:GPLv3 源码在GitHub上发布 github.com/muHua-usnnrqffjcqv/nlCrypto");
            }
            else
            {
                MessageBox.Show("Author:Muhua Version:latin5v1 ReleaseTime:2020/4/21 AuthonE-mail:usnnrqffjcqv@protonmail.com License:GPLv3 The source code is published on github : github.com/muHua-usnnrqffjcqv/nlCrypto");
            }

        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
            {
                // 手动汉化，因为用resx汉化会出多个文件，不好发布
                about.Text = "作者：慕华" + Environment.NewLine + "版本：latin5v1" + Environment.NewLine + "双击查看更多";
                enCode.Text = "编码";
                deCode.Text = "解码";
                clear.Text = "清空";
                useClipBoard.Text = "使用剪辑版";
                useCrypto.Text = "使用加密";
                useLongWord.Text = "使用长表";
                cryptoPage.Text = "加解密";
                ptpSecPage.Text = "端对端加密";
                ptpAbout.Text = "需要使用方法与介绍可以双击打开介绍页面";
                rsaKeyGen.Text = "公私钥生成";
                privateKeySel.Text = "选择您的私钥";
                publicKeySel.Text = "选择您加密讨论对象的公钥";
                tempKeyGen.Text = "临时通讯密钥生成";
                tempKeyDecode.Text = "解码对方的临时通讯密钥";
            }
        }
        private void mainForm_Activated(object sender, EventArgs e)
        {
            // 剪辑版处理
            if (useClipBoard.Checked == true)
            {
                IDataObject iData = Clipboard.GetDataObject();
                ioText.Text = (string)iData.GetData(DataFormats.Text);
            }
        }
        private void ptpAbout_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/muHua-usnnrqffjcqv/nlCrypto/wiki/Introduction-to-PTPSEC-and-how-to-use-it---%E5%AF%B9%E4%BA%8EPTPSEC%E7%9A%84%E4%BB%8B%E7%BB%8D%E5%8F%8A%E5%85%B6%E4%BD%BF%E7%94%A8%E6%96%B9%E6%B3%95");
        }
        private void rsaKeyGen_Click(object sender, EventArgs e)
        {
            rsa.KeyGen();
            string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
            {
                // 手动汉化，因为用resx汉化会出多个文件，不好发布
                MessageBox.Show("生成完毕,位置位于程序运行目录下,请备份到安全位置.并且请把你的公钥发给你可能需要加密通讯的联系人。");
            }
            else
            {
                MessageBox.Show("After the generation is completed, the location is located in the program running directory, please back up to a safe location. And please send your public key to the contact you may need to encrypt the communication.");
            }
        }
        private void privateKeySel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "nlCryptoPrivateKey|*.xml";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                privateKey = openFileDialog.FileName;
                openFileDialog.FileName = "";
            }
        }
        private void publicKeySel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "nlCryptoPublicKey|*.xml";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                publicKey = openFileDialog.FileName;
                openFileDialog.FileName = "";
            }
        }
        private void tempKeyGen_Click(object sender, EventArgs e)
        {
            if (publicKey == null || privateKey == null)
            {
                string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
                {
                    // 手动汉化，因为用resx汉化会出多个文件，不好发布
                    MessageBox.Show("请确认是否加载成功公私钥。");
                }
                else
                {
                    MessageBox.Show("Make sure that public and private key loaded successfully.");
                }
                return;
            }
            nlPtpsec.nlTempKey nlTempKey;
            nlTempKey = nlPtpsec.TempKeyGen(publicKey,useLongWord.Checked);
            outputBox.Text = nlTempKey.output;
            if (useClipBoard.Checked == true)
            {
                Clipboard.SetDataObject(outputBox.Text);
            }
            passwordText.Text = nlTempKey.encPwd.ToString();
        }
        private void tempKeyDecode_Click(object sender, EventArgs e)
        {
            if (publicKey == null || privateKey == null)
            {
                string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
                {
                    // 手动汉化，因为用resx汉化会出多个文件，不好发布
                    MessageBox.Show("请确认是否加载成功公私钥。");
                }
                else
                {
                    MessageBox.Show("Make sure that public and private key loaded successfully.");
                }
                return;
            }
            nlPtpsec.nlTempKey nlTempKey;
            nlTempKey.output = outputBox.Text;
            nlTempKey.encPwd = Convert.ToInt32(passwordText.Text);
            passwordText.Text = (nlPtpsec.nlTempKeyDecode(privateKey, nlTempKey).ToString());
        }
    }
}
