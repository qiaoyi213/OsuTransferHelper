using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void pathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void file_TextChanged(object sender, EventArgs e)
        {

        }
        private void logText_TextChanged(object sender, EventArgs e)
        {
            logText.SelectionLength = logText.TextLength;
            logText.ScrollToCaret();
        }

        private void fileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog path = new OpenFileDialog();
            path.Filter = "文字檔 (*.txt)|*.txt";
            if(path.ShowDialog() == DialogResult.OK)
            {
                fileText.Text = path.FileName;
            }
        }

        private void pathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            pathText.Text = path.SelectedPath.Replace("\\", "\\\\");
            if(pathText.Text[pathText.Text.Length-1] != '\\')
            {
                pathText.Text += "\\\\";
            }
        }
        private void progressBar_Click(object sender, EventArgs e)
        {

        }
        private void execBtn_Click(object sender, EventArgs e)
        {
            
            System.IO.StreamReader file = new System.IO.StreamReader(@fileText.Text);
            System.Collections.ArrayList dir = new System.Collections.ArrayList();
            string line;
            int numData = 0;
            logText.Text += "Loading file..." + Environment.NewLine;
            while ((line = file.ReadLine()) != null)
            {
                dir.Add(line);
                logText.Text += "Loading "+line + Environment.NewLine;
                numData++;
                Application.DoEvents();
            }
            progressBar.Maximum = numData;
            logText.Text += "Loading successful!" + Environment.NewLine;
            logText.Text += "Start Download" + Environment.NewLine;
            Application.DoEvents();
            
            file.Close();
            
            foreach (var item in dir)
            {
                string url = string.Format("https://beatconnect.io/b/{0}", item);
                string dwPath = string.Format("{0}{1}.osz", pathText.Text, item);
                //MessageBox.Show(dwPath);
                //string dwPath = "D:\\asdf.osz";
                WebClient wc = new WebClient();
                logText.Text += string.Format("Downloading {0}...{1}", item, Environment.NewLine);
                Application.DoEvents();
                wc.DownloadFile(url, dwPath);
                logText.Text += string.Format("{0} successful download! {1}",item,Environment.NewLine);
                Application.DoEvents();
                progressBar.Value++;
            }
            MessageBox.Show("Download Finished!","Finished !!");
        }
    }
}
