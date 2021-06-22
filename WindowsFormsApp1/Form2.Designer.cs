
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathSelect = new System.Windows.Forms.Button();
            this.execBtn = new System.Windows.Forms.Button();
            this.logText = new System.Windows.Forms.TextBox();
            this.pathSong = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.pathCompress = new System.Windows.Forms.Label();
            this.fileSelect = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.execText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathSelect
            // 
            this.pathSelect.Location = new System.Drawing.Point(985, 45);
            this.pathSelect.Name = "pathSelect";
            this.pathSelect.Size = new System.Drawing.Size(75, 23);
            this.pathSelect.TabIndex = 1;
            this.pathSelect.Text = "選擇路徑";
            this.pathSelect.UseVisualStyleBackColor = true;
            this.pathSelect.Click += new System.EventHandler(this.pathSelect_Click);
            // 
            // execBtn
            // 
            this.execBtn.AutoSize = true;
            this.execBtn.Location = new System.Drawing.Point(985, 126);
            this.execBtn.Name = "execBtn";
            this.execBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.execBtn.Size = new System.Drawing.Size(75, 23);
            this.execBtn.TabIndex = 2;
            this.execBtn.Text = "執行";
            this.execBtn.UseVisualStyleBackColor = true;
            this.execBtn.Click += new System.EventHandler(this.execBtn_Click);
            // 
            // logText
            // 
            this.logText.Cursor = System.Windows.Forms.Cursors.Default;
            this.logText.Location = new System.Drawing.Point(63, 158);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(904, 386);
            this.logText.TabIndex = 3;
            this.logText.TextChanged += new System.EventHandler(this.logText_TextChanged);
            // 
            // pathSong
            // 
            this.pathSong.AutoSize = true;
            this.pathSong.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pathSong.Location = new System.Drawing.Point(68, 43);
            this.pathSong.Name = "pathSong";
            this.pathSong.Size = new System.Drawing.Size(120, 19);
            this.pathSong.TabIndex = 5;
            this.pathSong.Text = "Osu!歌曲路徑";
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(188, 87);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(779, 22);
            this.fileText.TabIndex = 6;
            this.fileText.TextChanged += new System.EventHandler(this.fileText_TextChanged);
            // 
            // pathCompress
            // 
            this.pathCompress.AutoSize = true;
            this.pathCompress.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pathCompress.Location = new System.Drawing.Point(40, 87);
            this.pathCompress.Name = "pathCompress";
            this.pathCompress.Size = new System.Drawing.Size(142, 19);
            this.pathCompress.TabIndex = 7;
            this.pathCompress.Text = "壓縮檔輸出路徑";
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(985, 85);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(75, 23);
            this.fileSelect.TabIndex = 8;
            this.fileSelect.Text = "選擇路徑";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(188, 40);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(779, 22);
            this.pathText.TabIndex = 9;
            this.pathText.TextChanged += new System.EventHandler(this.pathText_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(188, 126);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(779, 23);
            this.progressBar.TabIndex = 10;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // execText
            // 
            this.execText.AutoSize = true;
            this.execText.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.execText.Location = new System.Drawing.Point(97, 126);
            this.execText.Name = "execText";
            this.execText.Size = new System.Drawing.Size(85, 19);
            this.execText.TabIndex = 11;
            this.execText.Text = "執行進度";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 606);
            this.Controls.Add(this.execText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.fileSelect);
            this.Controls.Add(this.pathCompress);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.pathSong);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.execBtn);
            this.Controls.Add(this.pathSelect);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pathSelect;
        private System.Windows.Forms.Button execBtn;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.Label pathSong;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.Label pathCompress;
        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label execText;
    }
}