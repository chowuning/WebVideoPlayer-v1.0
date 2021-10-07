/*
 * File Name:WebVideoPalyer(WVP)
 * Designer Number:1,16(School Number)
 * Language Tools:C#,HTMI
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WebVideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string _ytUrl;
        private string VideoId
        {
            get
            {
                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(_ytUrl);
                return ytMatch.Success ? ytMatch.Groups[1].Value : string.Empty;
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            _ytUrl = txtUrl.Text;
            webBrowser.Navigate($"http://youtube.com/v/{VideoId}?version=3");

            history = txtUrl.Text;
            histroylist.Items.Add(new MyItem("歷史紀錄" + historycount.ToString(), history));
            historycount++;
        }

        private void btnclswebsite_Click(object sender, EventArgs e)
        {
            txtUrl.Text="";
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        struct MyItem
        {
            public MyItem(string displayName, string realValue)
            {
                DisplayName = displayName;
                RealValue = realValue;
            }
            public string DisplayName { get; set; }
            public string RealValue { get; set; }
            // must have this override method to display the right string.
            public override string ToString()
            {
                return DisplayName;
            }
        }

        string like;
        int likecount = 1;

        private void btnaddlikelist_Click(object sender, EventArgs e)
        {
           like = txtUrl.Text;
           likelist.Items.Add(new MyItem("喜好" + likecount.ToString(), like));
           likecount++;
        }

        private void likelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrl.Text = ((MyItem)likelist.SelectedItem).RealValue;
        }
        private void btnclslikelist_Click(object sender, EventArgs e)
        {
            likelist.Items.Clear();
            likecount = 0;
            likelist.Text = "";
        }
        string history;
        int historycount = 1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrl.Text = ((MyItem)histroylist.SelectedItem).RealValue;
        }

        private void btnclshistory_Click(object sender, EventArgs e)
        {
            histroylist.Items.Clear();
            historycount = 0;
            histroylist.Text = "";
        }

        private void btnclsvideo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("about:blank");
        }
    }
}
