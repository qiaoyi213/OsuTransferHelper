using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections;
namespace WindowsFormsApp1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void pathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileText_TextChanged(object sender, EventArgs e)
        {

        }
        private void logText_TextChanged(object sender, EventArgs e)
        {
            logText.SelectionLength = logText.TextLength;
            logText.ScrollToCaret();
        }

        private void pathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            pathText.Text = path.SelectedPath;
        }
        private void fileSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            fileText.Text = path.SelectedPath.Replace("\\", "\\\\");
            if (fileText.Text[fileText.Text.Length - 1] == '\\')
            {
                fileText.Text += "output.txt";
            }
            else
            {
                fileText.Text += "\\\\output.txt";
            }
        }
        private void progressBar_Click(object sender, EventArgs e)
        {

        }
        private void execBtn_Click(object sender, EventArgs e)
        {
            string path = @pathText.Text;
            logText.Text += "Loading your song... Please wait..." + Environment.NewLine;
            Application.DoEvents();
            string[] dirs = Directory.GetDirectories(path);
            System.Collections.ArrayList dirlist = new System.Collections.ArrayList();
            int numFolder = dirs.Length, numRepeat = 0;
            progressBar.Maximum = numFolder;
            progressBar.Value = 0;
            
            foreach (string item in dirs)
            {
                string pattern = Path.GetFileNameWithoutExtension(item).ToString();
                logText.Text += "Loading "+ pattern + Environment.NewLine;
                if(dirlist.Contains(pattern.Split(' ')[0])){
                    numRepeat++;
                }
                else
                {
                    dirlist.Add(pattern.Split(' ')[0]);
                }
                Application.DoEvents();
                progressBar.Value++;
            }
            logText.Text += "Loading successful..." + Environment.NewLine;

            FileStream fs = new FileStream(fileText.Text, FileMode.Create);
            foreach (var item in dirlist)
            {
                //logText.Text += item + Environment.NewLine;
                byte[] data = System.Text.Encoding.Default.GetBytes(item.ToString() + Environment.NewLine);
                fs.Write(data, 0, data.Length);
            }
            string finishWord = String.Format("已經完成{0}首歌曲的壓縮{1}其中有{2}首歌曲重複", numFolder, Environment.NewLine, numRepeat);
            MessageBox.Show(finishWord, "Finish!");
            fs.Flush();
            fs.Close();
            
        }

        
    }
}
