namespace nlCrypto
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cryptoPage = new System.Windows.Forms.TabPage();
            this.about = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.useLongWord = new System.Windows.Forms.CheckBox();
            this.useCrypto = new System.Windows.Forms.CheckBox();
            this.useClipBoard = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.deCode = new System.Windows.Forms.Button();
            this.enCode = new System.Windows.Forms.Button();
            this.ioText = new System.Windows.Forms.TextBox();
            this.otherPage = new System.Windows.Forms.TabPage();
            this.iniAbout = new System.Windows.Forms.Label();
            this.openIniHtm = new System.Windows.Forms.Button();
            this.iniSel = new System.Windows.Forms.Button();
            this.tempKeyDecode = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.tempKeyGen = new System.Windows.Forms.Button();
            this.publicKeySel = new System.Windows.Forms.Button();
            this.privateKeySel = new System.Windows.Forms.Button();
            this.rsaKeyGen = new System.Windows.Forms.Button();
            this.ptpAbout = new System.Windows.Forms.Label();
            this.marsPage = new System.Windows.Forms.TabPage();
            this.marsPwd = new System.Windows.Forms.TextBox();
            this.marsClear = new System.Windows.Forms.Button();
            this.marsDec = new System.Windows.Forms.Button();
            this.marsEnc = new System.Windows.Forms.Button();
            this.marsIo = new System.Windows.Forms.TextBox();
            this.marsLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.cryptoPage.SuspendLayout();
            this.otherPage.SuspendLayout();
            this.marsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.cryptoPage);
            this.tabControl.Controls.Add(this.marsPage);
            this.tabControl.Controls.Add(this.otherPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(400, 290);
            this.tabControl.TabIndex = 0;
            // 
            // cryptoPage
            // 
            this.cryptoPage.Controls.Add(this.about);
            this.cryptoPage.Controls.Add(this.passwordText);
            this.cryptoPage.Controls.Add(this.useLongWord);
            this.cryptoPage.Controls.Add(this.useCrypto);
            this.cryptoPage.Controls.Add(this.useClipBoard);
            this.cryptoPage.Controls.Add(this.clear);
            this.cryptoPage.Controls.Add(this.deCode);
            this.cryptoPage.Controls.Add(this.enCode);
            this.cryptoPage.Controls.Add(this.ioText);
            this.cryptoPage.Location = new System.Drawing.Point(4, 22);
            this.cryptoPage.Name = "cryptoPage";
            this.cryptoPage.Padding = new System.Windows.Forms.Padding(3);
            this.cryptoPage.Size = new System.Drawing.Size(392, 264);
            this.cryptoPage.TabIndex = 0;
            this.cryptoPage.Text = "Crypto";
            this.cryptoPage.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(283, 195);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(83, 48);
            this.about.TabIndex = 18;
            this.about.Text = "author: muhua\r\nver: latin6v1\r\nDouble click \r\nto see more";
            this.about.DoubleClick += new System.EventHandler(this.about_DoubleClick);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(21, 222);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(256, 21);
            this.passwordText.TabIndex = 17;
            // 
            // useLongWord
            // 
            this.useLongWord.AutoSize = true;
            this.useLongWord.Checked = true;
            this.useLongWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useLongWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useLongWord.Location = new System.Drawing.Point(285, 174);
            this.useLongWord.Name = "useLongWord";
            this.useLongWord.Size = new System.Drawing.Size(90, 16);
            this.useLongWord.TabIndex = 16;
            this.useLongWord.Text = "useLongWord";
            this.useLongWord.UseVisualStyleBackColor = true;
            // 
            // useCrypto
            // 
            this.useCrypto.AutoSize = true;
            this.useCrypto.Checked = true;
            this.useCrypto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCrypto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useCrypto.Location = new System.Drawing.Point(285, 158);
            this.useCrypto.Name = "useCrypto";
            this.useCrypto.Size = new System.Drawing.Size(78, 16);
            this.useCrypto.TabIndex = 15;
            this.useCrypto.Text = "useCrypto";
            this.useCrypto.UseVisualStyleBackColor = true;
            // 
            // useClipBoard
            // 
            this.useClipBoard.AutoSize = true;
            this.useClipBoard.Checked = true;
            this.useClipBoard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useClipBoard.Location = new System.Drawing.Point(285, 142);
            this.useClipBoard.Name = "useClipBoard";
            this.useClipBoard.Size = new System.Drawing.Size(96, 16);
            this.useClipBoard.TabIndex = 14;
            this.useClipBoard.Text = "useClipBoard";
            this.useClipBoard.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(285, 102);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 32);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // deCode
            // 
            this.deCode.Location = new System.Drawing.Point(285, 62);
            this.deCode.Name = "deCode";
            this.deCode.Size = new System.Drawing.Size(80, 32);
            this.deCode.TabIndex = 12;
            this.deCode.Text = "deCode";
            this.deCode.UseVisualStyleBackColor = true;
            this.deCode.Click += new System.EventHandler(this.deCode_Click);
            // 
            // enCode
            // 
            this.enCode.Location = new System.Drawing.Point(285, 22);
            this.enCode.Name = "enCode";
            this.enCode.Size = new System.Drawing.Size(80, 32);
            this.enCode.TabIndex = 11;
            this.enCode.Text = "enCode";
            this.enCode.UseVisualStyleBackColor = true;
            this.enCode.Click += new System.EventHandler(this.enCode_Click);
            // 
            // ioText
            // 
            this.ioText.Location = new System.Drawing.Point(21, 22);
            this.ioText.Multiline = true;
            this.ioText.Name = "ioText";
            this.ioText.Size = new System.Drawing.Size(256, 192);
            this.ioText.TabIndex = 10;
            // 
            // otherPage
            // 
            this.otherPage.Controls.Add(this.iniAbout);
            this.otherPage.Controls.Add(this.openIniHtm);
            this.otherPage.Controls.Add(this.iniSel);
            this.otherPage.Controls.Add(this.tempKeyDecode);
            this.otherPage.Controls.Add(this.outputBox);
            this.otherPage.Controls.Add(this.tempKeyGen);
            this.otherPage.Controls.Add(this.publicKeySel);
            this.otherPage.Controls.Add(this.privateKeySel);
            this.otherPage.Controls.Add(this.rsaKeyGen);
            this.otherPage.Controls.Add(this.ptpAbout);
            this.otherPage.Location = new System.Drawing.Point(4, 22);
            this.otherPage.Name = "otherPage";
            this.otherPage.Padding = new System.Windows.Forms.Padding(3);
            this.otherPage.Size = new System.Drawing.Size(392, 264);
            this.otherPage.TabIndex = 1;
            this.otherPage.Text = "other";
            this.otherPage.UseVisualStyleBackColor = true;
            // 
            // iniAbout
            // 
            this.iniAbout.AutoSize = true;
            this.iniAbout.Location = new System.Drawing.Point(282, 124);
            this.iniAbout.Name = "iniAbout";
            this.iniAbout.Size = new System.Drawing.Size(47, 12);
            this.iniAbout.TabIndex = 10;
            this.iniAbout.Text = "nothing";
            // 
            // openIniHtm
            // 
            this.openIniHtm.Location = new System.Drawing.Point(284, 209);
            this.openIniHtm.Name = "openIniHtm";
            this.openIniHtm.Size = new System.Drawing.Size(75, 23);
            this.openIniHtm.TabIndex = 8;
            this.openIniHtm.Text = "openIniHtm";
            this.openIniHtm.UseVisualStyleBackColor = true;
            this.openIniHtm.Click += new System.EventHandler(this.openIniHtm_Click);
            // 
            // iniSel
            // 
            this.iniSel.Location = new System.Drawing.Point(284, 180);
            this.iniSel.Name = "iniSel";
            this.iniSel.Size = new System.Drawing.Size(75, 23);
            this.iniSel.TabIndex = 7;
            this.iniSel.Text = "iniSel";
            this.iniSel.UseVisualStyleBackColor = true;
            this.iniSel.Click += new System.EventHandler(this.iniSel_Click);
            // 
            // tempKeyDecode
            // 
            this.tempKeyDecode.Enabled = false;
            this.tempKeyDecode.Location = new System.Drawing.Point(41, 209);
            this.tempKeyDecode.Name = "tempKeyDecode";
            this.tempKeyDecode.Size = new System.Drawing.Size(223, 23);
            this.tempKeyDecode.TabIndex = 6;
            this.tempKeyDecode.Text = "Decrypt temporary communication key";
            this.tempKeyDecode.UseVisualStyleBackColor = true;
            this.tempKeyDecode.Click += new System.EventHandler(this.tempKeyDecode_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(41, 182);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(223, 21);
            this.outputBox.TabIndex = 5;
            // 
            // tempKeyGen
            // 
            this.tempKeyGen.Location = new System.Drawing.Point(41, 153);
            this.tempKeyGen.Name = "tempKeyGen";
            this.tempKeyGen.Size = new System.Drawing.Size(223, 23);
            this.tempKeyGen.TabIndex = 4;
            this.tempKeyGen.Text = "Generate temp communication key";
            this.tempKeyGen.UseVisualStyleBackColor = true;
            this.tempKeyGen.Click += new System.EventHandler(this.tempKeyGen_Click);
            // 
            // publicKeySel
            // 
            this.publicKeySel.Location = new System.Drawing.Point(41, 124);
            this.publicKeySel.Name = "publicKeySel";
            this.publicKeySel.Size = new System.Drawing.Size(223, 23);
            this.publicKeySel.TabIndex = 3;
            this.publicKeySel.Text = "public key of the correspondent\r\n";
            this.publicKeySel.UseVisualStyleBackColor = true;
            this.publicKeySel.Click += new System.EventHandler(this.publicKeySel_Click);
            // 
            // privateKeySel
            // 
            this.privateKeySel.Location = new System.Drawing.Point(41, 95);
            this.privateKeySel.Name = "privateKeySel";
            this.privateKeySel.Size = new System.Drawing.Size(223, 23);
            this.privateKeySel.TabIndex = 2;
            this.privateKeySel.Text = "Private key select";
            this.privateKeySel.UseVisualStyleBackColor = true;
            this.privateKeySel.Click += new System.EventHandler(this.privateKeySel_Click);
            // 
            // rsaKeyGen
            // 
            this.rsaKeyGen.Location = new System.Drawing.Point(41, 66);
            this.rsaKeyGen.Name = "rsaKeyGen";
            this.rsaKeyGen.Size = new System.Drawing.Size(223, 23);
            this.rsaKeyGen.TabIndex = 1;
            this.rsaKeyGen.Text = "Public and private key generation";
            this.rsaKeyGen.UseVisualStyleBackColor = true;
            this.rsaKeyGen.Click += new System.EventHandler(this.rsaKeyGen_Click);
            // 
            // ptpAbout
            // 
            this.ptpAbout.AutoSize = true;
            this.ptpAbout.Location = new System.Drawing.Point(39, 27);
            this.ptpAbout.Name = "ptpAbout";
            this.ptpAbout.Size = new System.Drawing.Size(347, 24);
            this.ptpAbout.TabIndex = 0;
            this.ptpAbout.Text = "Need to use the method and introduction can double-click \r\nto open the introducti" +
    "on page";
            this.ptpAbout.DoubleClick += new System.EventHandler(this.ptpAbout_DoubleClick);
            // 
            // marsPage
            // 
            this.marsPage.Controls.Add(this.marsLabel);
            this.marsPage.Controls.Add(this.marsPwd);
            this.marsPage.Controls.Add(this.marsClear);
            this.marsPage.Controls.Add(this.marsDec);
            this.marsPage.Controls.Add(this.marsEnc);
            this.marsPage.Controls.Add(this.marsIo);
            this.marsPage.Location = new System.Drawing.Point(4, 22);
            this.marsPage.Name = "marsPage";
            this.marsPage.Padding = new System.Windows.Forms.Padding(3);
            this.marsPage.Size = new System.Drawing.Size(392, 264);
            this.marsPage.TabIndex = 2;
            this.marsPage.Text = "marsCode";
            this.marsPage.UseVisualStyleBackColor = true;
            // 
            // marsPwd
            // 
            this.marsPwd.Location = new System.Drawing.Point(282, 136);
            this.marsPwd.Multiline = true;
            this.marsPwd.Name = "marsPwd";
            this.marsPwd.Size = new System.Drawing.Size(80, 72);
            this.marsPwd.TabIndex = 23;
            // 
            // marsClear
            // 
            this.marsClear.Location = new System.Drawing.Point(282, 98);
            this.marsClear.Name = "marsClear";
            this.marsClear.Size = new System.Drawing.Size(80, 32);
            this.marsClear.TabIndex = 22;
            this.marsClear.Text = "clear";
            this.marsClear.UseVisualStyleBackColor = true;
            this.marsClear.Click += new System.EventHandler(this.marsClear_Click);
            // 
            // marsDec
            // 
            this.marsDec.Location = new System.Drawing.Point(282, 58);
            this.marsDec.Name = "marsDec";
            this.marsDec.Size = new System.Drawing.Size(80, 32);
            this.marsDec.TabIndex = 21;
            this.marsDec.Text = "deCode";
            this.marsDec.UseVisualStyleBackColor = true;
            this.marsDec.Click += new System.EventHandler(this.marsDec_Click);
            // 
            // marsEnc
            // 
            this.marsEnc.Location = new System.Drawing.Point(282, 18);
            this.marsEnc.Name = "marsEnc";
            this.marsEnc.Size = new System.Drawing.Size(80, 32);
            this.marsEnc.TabIndex = 20;
            this.marsEnc.Text = "enCode";
            this.marsEnc.UseVisualStyleBackColor = true;
            this.marsEnc.Click += new System.EventHandler(this.marsEnc_Click);
            // 
            // marsIo
            // 
            this.marsIo.Location = new System.Drawing.Point(18, 18);
            this.marsIo.Multiline = true;
            this.marsIo.Name = "marsIo";
            this.marsIo.Size = new System.Drawing.Size(256, 190);
            this.marsIo.TabIndex = 19;
            // 
            // marsLabel
            // 
            this.marsLabel.AutoSize = true;
            this.marsLabel.Location = new System.Drawing.Point(15, 211);
            this.marsLabel.Name = "marsLabel";
            this.marsLabel.Size = new System.Drawing.Size(365, 36);
            this.marsLabel.TabIndex = 24;
            this.marsLabel.Text = "The algorithm comes from the mobile software Mars ciphertext\r\n and is released in" +
    " GPLv3. If there is any infringement,\r\n please contact the author\'s email";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 360);
            this.MinimumSize = new System.Drawing.Size(450, 360);
            this.Name = "mainForm";
            this.Text = "nlCryptoLatin6v1";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.cryptoPage.ResumeLayout(false);
            this.cryptoPage.PerformLayout();
            this.otherPage.ResumeLayout(false);
            this.otherPage.PerformLayout();
            this.marsPage.ResumeLayout(false);
            this.marsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage cryptoPage;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.CheckBox useLongWord;
        private System.Windows.Forms.CheckBox useCrypto;
        private System.Windows.Forms.CheckBox useClipBoard;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button deCode;
        private System.Windows.Forms.Button enCode;
        private System.Windows.Forms.TextBox ioText;
        private System.Windows.Forms.TabPage otherPage;
        private System.Windows.Forms.Label ptpAbout;
        private System.Windows.Forms.Button rsaKeyGen;
        private System.Windows.Forms.Button publicKeySel;
        private System.Windows.Forms.Button privateKeySel;
        private System.Windows.Forms.Button tempKeyGen;
        private System.Windows.Forms.Button tempKeyDecode;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button iniSel;
        private System.Windows.Forms.Label iniAbout;
        private System.Windows.Forms.Button openIniHtm;
        private System.Windows.Forms.TabPage marsPage;
        private System.Windows.Forms.Label marsLabel;
        private System.Windows.Forms.TextBox marsPwd;
        private System.Windows.Forms.Button marsClear;
        private System.Windows.Forms.Button marsDec;
        private System.Windows.Forms.Button marsEnc;
        private System.Windows.Forms.TextBox marsIo;
    }
}

