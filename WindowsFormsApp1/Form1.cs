using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        Form2 f_compose;
        Form3 f_decompose;

        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            f_compose = new Form2();
            f_decompose = new Form3();
        }

        private void borderTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void borderTitle_MouseDown(object sender, MouseEventArgs e)
        { 
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void borderTitle_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void borderTitle_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void navBar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void mainFram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            this.mainFram.Controls.Clear();
            f_compose.TopLevel = false;
            f_compose.FormBorderStyle = FormBorderStyle.None;
            f_compose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFram.Controls.Add(f_compose);
            f_compose.Show();
        }

        private void btnDecompose_Click(object sender, EventArgs e)
        {
            this.mainFram.Controls.Clear();
            f_decompose.TopLevel = false;
            f_decompose.FormBorderStyle = FormBorderStyle.None;
            f_decompose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFram.Controls.Add(f_decompose);
            f_decompose.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
