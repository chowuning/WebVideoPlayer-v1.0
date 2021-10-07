namespace WebVideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnleave = new System.Windows.Forms.Button();
            this.btnclswebsite = new System.Windows.Forms.Button();
            this.btnclslikelist = new System.Windows.Forms.Button();
            this.btnaddlikelist = new System.Windows.Forms.Button();
            this.btnclsvideo = new System.Windows.Forms.Button();
            this.btnclshistory = new System.Windows.Forms.Button();
            this.likelist = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.histroylist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube網址:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(595, 469);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 39);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "&尋找";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(104, 476);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(485, 25);
            this.txtUrl.TabIndex = 2;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(654, 451);
            this.webBrowser.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnleave);
            this.groupBox1.Controls.Add(this.btnclswebsite);
            this.groupBox1.Controls.Add(this.btnclslikelist);
            this.groupBox1.Controls.Add(this.btnaddlikelist);
            this.groupBox1.Controls.Add(this.btnclsvideo);
            this.groupBox1.Controls.Add(this.btnclshistory);
            this.groupBox1.Location = new System.Drawing.Point(13, 507);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能選單";
            // 
            // btnleave
            // 
            this.btnleave.Location = new System.Drawing.Point(473, 99);
            this.btnleave.Name = "btnleave";
            this.btnleave.Size = new System.Drawing.Size(87, 48);
            this.btnleave.TabIndex = 5;
            this.btnleave.Text = "離開";
            this.btnleave.UseVisualStyleBackColor = true;
            this.btnleave.Click += new System.EventHandler(this.btnleave_Click);
            // 
            // btnclswebsite
            // 
            this.btnclswebsite.Location = new System.Drawing.Point(473, 26);
            this.btnclswebsite.Name = "btnclswebsite";
            this.btnclswebsite.Size = new System.Drawing.Size(87, 48);
            this.btnclswebsite.TabIndex = 4;
            this.btnclswebsite.Text = "   清除     網址";
            this.btnclswebsite.UseVisualStyleBackColor = true;
            this.btnclswebsite.Click += new System.EventHandler(this.btnclswebsite_Click);
            // 
            // btnclslikelist
            // 
            this.btnclslikelist.Location = new System.Drawing.Point(91, 99);
            this.btnclslikelist.Name = "btnclslikelist";
            this.btnclslikelist.Size = new System.Drawing.Size(87, 48);
            this.btnclslikelist.TabIndex = 3;
            this.btnclslikelist.Text = "   清除    喜愛清單";
            this.btnclslikelist.UseVisualStyleBackColor = true;
            this.btnclslikelist.Click += new System.EventHandler(this.btnclslikelist_Click);
            // 
            // btnaddlikelist
            // 
            this.btnaddlikelist.Location = new System.Drawing.Point(91, 25);
            this.btnaddlikelist.Name = "btnaddlikelist";
            this.btnaddlikelist.Size = new System.Drawing.Size(87, 48);
            this.btnaddlikelist.TabIndex = 2;
            this.btnaddlikelist.Text = "   加入    喜愛清單";
            this.btnaddlikelist.UseVisualStyleBackColor = true;
            this.btnaddlikelist.Click += new System.EventHandler(this.btnaddlikelist_Click);
            // 
            // btnclsvideo
            // 
            this.btnclsvideo.Location = new System.Drawing.Point(276, 26);
            this.btnclsvideo.Name = "btnclsvideo";
            this.btnclsvideo.Size = new System.Drawing.Size(87, 47);
            this.btnclsvideo.TabIndex = 1;
            this.btnclsvideo.Text = "   清除     影片";
            this.btnclsvideo.UseVisualStyleBackColor = true;
            this.btnclsvideo.Click += new System.EventHandler(this.btnclsvideo_Click);
            // 
            // btnclshistory
            // 
            this.btnclshistory.Location = new System.Drawing.Point(276, 99);
            this.btnclshistory.Name = "btnclshistory";
            this.btnclshistory.Size = new System.Drawing.Size(87, 48);
            this.btnclshistory.TabIndex = 0;
            this.btnclshistory.Text = "   清除    歷史紀錄";
            this.btnclshistory.UseVisualStyleBackColor = true;
            this.btnclshistory.Click += new System.EventHandler(this.btnclshistory_Click);
            // 
            // likelist
            // 
            this.likelist.FormattingEnabled = true;
            this.likelist.Location = new System.Drawing.Point(700, 342);
            this.likelist.Name = "likelist";
            this.likelist.Size = new System.Drawing.Size(132, 23);
            this.likelist.TabIndex = 5;
            this.likelist.SelectedIndexChanged += new System.EventHandler(this.likelist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "喜好清單";
            // 
            // histroylist
            // 
            this.histroylist.FormattingEnabled = true;
            this.histroylist.Location = new System.Drawing.Point(700, 30);
            this.histroylist.Name = "histroylist";
            this.histroylist.Size = new System.Drawing.Size(132, 23);
            this.histroylist.TabIndex = 7;
            this.histroylist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "歷史紀錄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 688);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.histroylist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.likelist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "網頁影片播放器";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnleave;
        private System.Windows.Forms.Button btnclswebsite;
        private System.Windows.Forms.Button btnclslikelist;
        private System.Windows.Forms.Button btnaddlikelist;
        private System.Windows.Forms.Button btnclsvideo;
        private System.Windows.Forms.Button btnclshistory;
        private System.Windows.Forms.ComboBox likelist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox histroylist;
        private System.Windows.Forms.Label label3;
    }
}

