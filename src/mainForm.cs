using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Clipboard = System.Windows.Forms.Clipboard;

namespace nlCrypto
{
    public partial class mainForm : Form
    {

        string privateKey;
        string publicKey;
        string nlbIni;
        // 应用程序版本号
        // 注：更改了这个还要改assemblyInfo和页面显示
        string version = "latin6v1";
        string time = "2020/5/4";
        public mainForm()
        {
            InitializeComponent();
        }
        private void enCode_Click(object sender, EventArgs e)
        {
            ioText.Text = nlc.encode(ioText.Text, passwordText.Text, useCrypto.Checked, useLongWord.Checked);
            if (useClipBoard.Checked == true)
            {
                Clipboard.SetText(ioText.Text);
            }
        }
        private void deCode_Click(object sender, EventArgs e)
        {
            ioText.Text = nlc.decode(ioText.Text, passwordText.Text, useCrypto.Checked);
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
                MessageBox.Show("作者:慕华 版本:" + version + " 发布时间: " + time + " 作者邮箱:usnnrqffjcqv@protonmail.com 许可证:GPLv3 源码在GitHub上发布 github.com/muHua-usnnrqffjcqv/nlCrypto");
            }
            else
            {
                MessageBox.Show("Author:Muhua Version:" + version + " ReleaseTime:" + time + " AuthonE-mail:usnnrqffjcqv@protonmail.com License:GPLv3 The source code is published on github : github.com/muHua-usnnrqffjcqv/nlCrypto");
            }

        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            ini ini = new ini(System.Environment.GetEnvironmentVariable("APPDATA") + "\\nlCryptoSettings.ini");
            // info.FullName就是临时目录的字符串
            string temp = System.Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            string path = info.FullName;
            // 如果是使用nlbIni
            nlbIni = ini.ReadValue("ini", "nlbIni");
            if (nlbIni != "")
            {
                // 写到文件
                FileInfo fi1 = new FileInfo(nlbIni);
                fi1.CopyTo(path + "\\code.ini", true);
                // INIABOUT搞好
                ini inib = new ini(nlbIni);
                if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
                {
                    // 手动汉化，因为用resx汉化会出多个文件，不好发布
                    iniAbout.Text = Encoding.Default.GetString(Convert.FromBase64String(inib.ReadValue("about", "chinese")));
                }
                else
                {
                    iniAbout.Text = Encoding.Default.GetString(Convert.FromBase64String(inib.ReadValue("about", "english")));
                }
            }
            // 如果不是使用nlbIni
            else
            {
                // 从网上找的资源文件写到路径代码
                File.WriteAllBytes(path + "\\code.ini", System.Text.Encoding.Default.GetBytes(Properties.Resources.code));
                // 资源文件的code写到%temp%\code.ini
                iniAbout.Text = "usingDefault";
                nlbIni = "";
            }
            // 私钥
            privateKey = ini.ReadValue("key", "privateKey");
            // 汉化
            if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
            {
                // 手动汉化，因为用resx汉化会出多个文件，不好发布
                about.Text = "作者：慕华" + Environment.NewLine + "版本：" + version + Environment.NewLine + "双击查看更多";
                enCode.Text = "编码";
                deCode.Text = "解码";
                clear.Text = "清空";
                useClipBoard.Text = "使用剪辑版";
                useCrypto.Text = "使用加密";
                useLongWord.Text = "使用长表";
                cryptoPage.Text = "加解密";
                otherPage.Text = "杂项";
                ptpAbout.Text = "需要使用方法与介绍可以双击打开介绍页面";
                rsaKeyGen.Text = "公私钥生成";
                privateKeySel.Text = "选择您的私钥";
                publicKeySel.Text = "选择您加密讨论对象的公钥";
                tempKeyGen.Text = "临时通讯密钥生成";
                tempKeyDecode.Text = "解码对方的临时通讯密钥";
                iniSel.Text = "INI选择";
                openIniHtm.Text = "INI网页";
                marsClear.Text = "清空";
                marsDec.Text = "解码";
                marsEnc.Text = "编码";
                marsLabel.Text = "算法来自手机软件《火星密文》" + "\r\n" + "并使用GPLv3发布到Github" + "\r\n" + "如有侵权请联系作者邮箱";
                marsPage.Text = "火星密文";
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
                MessageBox.Show("生成完毕,位置位于用户文件夹下的KEYS文件夹,请备份到安全位置.并且请把你的公钥发给你可能需要加密通讯的联系人。");
            }
            else
            {
                MessageBox.Show("After the generation is complete, the location is located in the KEYS folder under the user folder. Please back up to a safe location. And please send your public key to your contacts who may need to encrypt communications.");
            }
        }
        private void privateKeySel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.GetEnvironmentVariable("UserProfile") + "\\Keys";
            openFileDialog.Filter = "nlCryptoPrivateKey|*.xml";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                privateKey = openFileDialog.FileName;
                openFileDialog.FileName = "";
                ini ini = new ini(System.Environment.GetEnvironmentVariable("APPDATA") + "\\nlCryptoSettings.ini");
                ini.Writue("key", "privateKey", privateKey);
                string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
                {
                    // 手动汉化，因为用resx汉化会出多个文件，不好发布
                    MessageBox.Show("已帮您记住此次的私钥选择，下次就不用再次选择了。");
                }
                else
                {
                    MessageBox.Show("I have helped you remember the choice of the private key this time, so you don't have to choose it again next time.");
                }
            }
        }
        private void publicKeySel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.Environment.GetEnvironmentVariable("UserProfile") + "\\Keys";
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
            nlTempKey = nlPtpsec.TempKeyGen(publicKey, useLongWord.Checked);
            outputBox.Text = nlTempKey.output;
            if (useClipBoard.Checked == true)
            {
                Clipboard.SetDataObject(outputBox.Text);
            }
            passwordText.Text = nlTempKey.encPwd.ToString();
            tempKeyDecode.Enabled = true;
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
            tempKeyDecode.Enabled = false;
        }

        private void iniSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetEnvironmentVariable("UserProfile") + "\\nlcIni";
            openFileDialog.Filter = "nlBase64ini|*.ini";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            string temp = System.Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            string path = info.FullName;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nlbIni = openFileDialog.FileName;
                openFileDialog.FileName = "";
                ini inia = new ini(System.Environment.GetEnvironmentVariable("APPDATA") + "\\nlCryptoSettings.ini");
                inia.Writue("ini", "nlbIni", nlbIni);
                ini inib = new ini(nlbIni);
                string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                // 写道文件
                FileInfo fi1 = new FileInfo(nlbIni);
                fi1.CopyTo(path + "\\code.ini", true);
                // INIABOUT搞好
                if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
                {
                    // 手动汉化，因为用resx汉化会出多个文件，不好发布
                    iniAbout.Text = Encoding.Default.GetString(Convert.FromBase64String(inib.ReadValue("about", "chinese")));
                }
                else
                {
                    iniAbout.Text = Encoding.Default.GetString(Convert.FromBase64String(inib.ReadValue("about", "english")));
                }

            }
            // 清空nlbIni
            else
            {
                // 从网上找的资源文件写到路径代码
                File.WriteAllBytes(path + "\\code.ini", System.Text.Encoding.Default.GetBytes(Properties.Resources.code));
                // 资源文件的code写到%temp%\code.ini
                iniAbout.Text = "usingDefault";
                nlbIni = "";
                ini inia = new ini(Environment.GetEnvironmentVariable("APPDATA") + "\\nlCryptoSettings.ini");
                inia.Writue("ini", "nlbIni", "");

            }
        }

        private void openIniHtm_Click(object sender, EventArgs e)
        {
            ini ini = new ini(nlbIni);
            // info.FullName就是临时目录的字符串
            string temp = System.Environment.GetEnvironmentVariable("TEMP");
            DirectoryInfo info = new DirectoryInfo(temp);
            string path = info.FullName;
            string tempString = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            if (tempString == "zh" || tempString == "zh-CN" || tempString == "zh-MO" || tempString == "zh-Hans" || tempString == "zh-SG" || tempString == "zh-Hans" || tempString == "zh-Hant" || tempString == "zh-TW")
            {
                // 手动汉化，因为用resx汉化会出多个文件，不好发布
                File.WriteAllText(path + "\\iniHelp.html", Encoding.Default.GetString(Convert.FromBase64String(ini.ReadValue("htm", "chinese"))));
                System.Diagnostics.Process.Start(path + "\\iniHelp.html");
            }
            else
            {
                File.WriteAllText(path + "\\iniHelp.html", Encoding.Default.GetString(Convert.FromBase64String(ini.ReadValue("htm", "english"))));
                System.Diagnostics.Process.Start(path + "\\iniHelp.html");
            }
        }

        private void marsClear_Click(object sender, EventArgs e)
        {
            marsIo.Text = "";
        }

        private void marsDec_Click(object sender, EventArgs e)
        {
            marsCode marsCode = new marsCode(marsPwd.Text);
            marsIo.Text = marsCode.dec(marsIo.Text);
        }

        private void marsEnc_Click(object sender, EventArgs e)
        {
            marsCode marsCode = new marsCode(marsPwd.Text);
            marsIo.Text = marsCode.enc(marsIo.Text);
        }
    }
}
