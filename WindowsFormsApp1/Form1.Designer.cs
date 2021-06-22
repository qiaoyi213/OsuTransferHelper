
namespace WindowsFormsApp1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.borderTitle = new System.Windows.Forms.Panel();
            this.mainFram = new System.Windows.Forms.Panel();
            this.navBar = new System.Windows.Forms.Panel();
            this.btnDecompose = new System.Windows.Forms.Button();
            this.btnCompose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.borderTitle.SuspendLayout();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderTitle
            // 
            this.borderTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.borderTitle.Controls.Add(this.Title);
            this.borderTitle.Controls.Add(this.btnClose);
            this.borderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTitle.Location = new System.Drawing.Point(0, 0);
            this.borderTitle.Name = "borderTitle";
            this.borderTitle.Size = new System.Drawing.Size(1264, 36);
            this.borderTitle.TabIndex = 2;
            this.borderTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.borderTitle_Paint);
            // 
            // mainFram
            // 
            this.mainFram.AutoSize = true;
            this.mainFram.BackColor = System.Drawing.SystemColors.Control;
            this.mainFram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFram.Location = new System.Drawing.Point(142, 36);
            this.mainFram.Name = "mainFram";
            this.mainFram.Size = new System.Drawing.Size(1122, 645);
            this.mainFram.TabIndex = 4;
            this.mainFram.Paint += new System.Windows.Forms.PaintEventHandler(this.mainFram_Paint);
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.LightCoral;
            this.navBar.Controls.Add(this.btnDecompose);
            this.navBar.Controls.Add(this.btnCompose);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Location = new System.Drawing.Point(0, 36);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(142, 645);
            this.navBar.TabIndex = 3;
            this.navBar.Paint += new System.Windows.Forms.PaintEventHandler(this.navBar_Paint);
            // 
            // btnDecompose
            // 
            this.btnDecompose.FlatAppearance.BorderSize = 0;
            this.btnDecompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecompose.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDecompose.Location = new System.Drawing.Point(3, 76);
            this.btnDecompose.Name = "btnDecompose";
            this.btnDecompose.Size = new System.Drawing.Size(139, 54);
            this.btnDecompose.TabIndex = 1;
            this.btnDecompose.Text = "解壓歌曲";
            this.btnDecompose.UseVisualStyleBackColor = true;
            this.btnDecompose.Click += new System.EventHandler(this.btnDecompose_Click);
            // 
            // btnCompose
            // 
            this.btnCompose.FlatAppearance.BorderSize = 0;
            this.btnCompose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompose.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCompose.Location = new System.Drawing.Point(0, 16);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(142, 54);
            this.btnCompose.TabIndex = 0;
            this.btnCompose.Text = "壓縮歌曲";
            this.btnCompose.UseVisualStyleBackColor = true;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.iconfinder_1814098_close_no_reject_icon_512px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1212, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Title.Location = new System.Drawing.Point(12, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(121, 19);
            this.Title.TabIndex = 1;
            this.Title.Text = "Osu! 轉移小幫手";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainFram);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.borderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.borderTitle.ResumeLayout(false);
            this.borderTitle.PerformLayout();
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel borderTitle;
        private System.Windows.Forms.Panel mainFram;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Button btnDecompose;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Title;
    }
}

