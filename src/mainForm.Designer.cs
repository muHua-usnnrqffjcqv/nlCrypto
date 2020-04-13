namespace nlCryptoLatin
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
            this.about = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.useLongWord = new System.Windows.Forms.CheckBox();
            this.useCrypto = new System.Windows.Forms.CheckBox();
            this.useClipBoard = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.deCode = new System.Windows.Forms.Button();
            this.enCode = new System.Windows.Forms.Button();
            this.ioText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(279, 194);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(83, 48);
            this.about.TabIndex = 9;
            this.about.Text = "author: muhua\r\nver: latin4v3\r\nDouble click \r\nto see more";
            this.about.DoubleClick += new System.EventHandler(this.about_DoubleClick);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(16, 216);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(256, 21);
            this.passwordText.TabIndex = 8;
            // 
            // useLongWord
            // 
            this.useLongWord.AutoSize = true;
            this.useLongWord.Checked = true;
            this.useLongWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useLongWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useLongWord.Location = new System.Drawing.Point(280, 168);
            this.useLongWord.Name = "useLongWord";
            this.useLongWord.Size = new System.Drawing.Size(90, 16);
            this.useLongWord.TabIndex = 6;
            this.useLongWord.Text = "useLongWord";
            this.useLongWord.UseVisualStyleBackColor = true;
            // 
            // useCrypto
            // 
            this.useCrypto.AutoSize = true;
            this.useCrypto.Checked = true;
            this.useCrypto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCrypto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.useCrypto.Location = new System.Drawing.Point(280, 152);
            this.useCrypto.Name = "useCrypto";
            this.useCrypto.Size = new System.Drawing.Size(78, 16);
            this.useCrypto.TabIndex = 5;
            this.useCrypto.Text = "useCrypto";
            this.useCrypto.UseVisualStyleBackColor = true;
            // 
            // useClipBoard
            // 
            this.useClipBoard.AutoSize = true;
            this.useClipBoard.Checked = true;
            this.useClipBoard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useClipBoard.Location = new System.Drawing.Point(280, 136);
            this.useClipBoard.Name = "useClipBoard";
            this.useClipBoard.Size = new System.Drawing.Size(96, 16);
            this.useClipBoard.TabIndex = 4;
            this.useClipBoard.Text = "useClipBoard";
            this.useClipBoard.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(280, 96);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 32);
            this.clear.TabIndex = 3;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // deCode
            // 
            this.deCode.Location = new System.Drawing.Point(280, 56);
            this.deCode.Name = "deCode";
            this.deCode.Size = new System.Drawing.Size(80, 32);
            this.deCode.TabIndex = 2;
            this.deCode.Text = "deCode";
            this.deCode.UseVisualStyleBackColor = true;
            this.deCode.Click += new System.EventHandler(this.deCode_Click);
            // 
            // enCode
            // 
            this.enCode.Location = new System.Drawing.Point(280, 16);
            this.enCode.Name = "enCode";
            this.enCode.Size = new System.Drawing.Size(80, 32);
            this.enCode.TabIndex = 1;
            this.enCode.Text = "enCode";
            this.enCode.UseVisualStyleBackColor = true;
            this.enCode.Click += new System.EventHandler(this.enCode_Click);
            // 
            // ioText
            // 
            this.ioText.Location = new System.Drawing.Point(16, 16);
            this.ioText.Multiline = true;
            this.ioText.Name = "ioText";
            this.ioText.Size = new System.Drawing.Size(256, 192);
            this.ioText.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 251);
            this.Controls.Add(this.about);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.useLongWord);
            this.Controls.Add(this.useCrypto);
            this.Controls.Add(this.useClipBoard);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.deCode);
            this.Controls.Add(this.enCode);
            this.Controls.Add(this.ioText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 290);
            this.MinimumSize = new System.Drawing.Size(390, 290);
            this.Name = "mainForm";
            this.Text = "nlCryptoLatin4v3";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label about;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.CheckBox useLongWord;
        private System.Windows.Forms.CheckBox useCrypto;
        private System.Windows.Forms.CheckBox useClipBoard;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button deCode;
        private System.Windows.Forms.Button enCode;
        private System.Windows.Forms.TextBox ioText;
    }
}

