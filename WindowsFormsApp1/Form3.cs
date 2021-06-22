using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            pathText.Text = path.SelectedPath;
        }

        private void execBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
