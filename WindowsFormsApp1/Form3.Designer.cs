
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.execBtn = new System.Windows.Forms.Button();
            this.pathCompress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fileSelect = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathSelect = new System.Windows.Forms.Button();
            this.pathSong = new System.Windows.Forms.Label();
            this.fileText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // execBtn
            // 
            this.execBtn.AutoSize = true;
            this.execBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.execBtn.Location = new System.Drawing.Point(978, 117);
            this.execBtn.Name = "execBtn";
            this.execBtn.Size = new System.Drawing.Size(75, 26);
            this.execBtn.TabIndex = 2;
            this.execBtn.Text = "執行";
            this.execBtn.UseCompatibleTextRendering = true;
            this.execBtn.UseVisualStyleBackColor = true;
            this.execBtn.Click += new System.EventHandler(this.execBtn_Click);
            // 
            // pathCompress
            // 
            this.pathCompress.AutoSize = true;
            this.pathCompress.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pathCompress.Location = new System.Drawing.Point(74, 39);
            this.pathCompress.Name = "pathCompress";
            this.pathCompress.Size = new System.Drawing.Size(104, 19);
            this.pathCompress.TabIndex = 5;
            this.pathCompress.Text = "壓縮檔路徑";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(895, 22);
            this.textBox2.TabIndex = 6;
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(978, 37);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(75, 23);
            this.fileSelect.TabIndex = 7;
            this.fileSelect.Text = "選擇檔案";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(184, 77);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(779, 22);
            this.pathText.TabIndex = 8;
            this.pathText.TextChanged += new System.EventHandler(this.pathText_TextChanged);
            // 
            // pathSelect
            // 
            this.pathSelect.Location = new System.Drawing.Point(978, 77);
            this.pathSelect.Name = "pathSelect";
            this.pathSelect.Size = new System.Drawing.Size(75, 23);
            this.pathSelect.TabIndex = 9;
            this.pathSelect.Text = "選擇路徑";
            this.pathSelect.UseVisualStyleBackColor = true;
            this.pathSelect.Click += new System.EventHandler(this.pathSelect_Click);
            // 
            // pathSong
            // 
            this.pathSong.AutoSize = true;
            this.pathSong.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pathSong.Location = new System.Drawing.Point(64, 81);
            this.pathSong.Name = "pathSong";
            this.pathSong.Size = new System.Drawing.Size(120, 19);
            this.pathSong.TabIndex = 10;
            this.pathSong.Text = "Osu!歌曲路徑";
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(184, 38);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(779, 22);
            this.fileText.TabIndex = 11;
            this.fileText.TextChanged += new System.EventHandler(this.file_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(779, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 606);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.pathSong);
            this.Controls.Add(this.pathSelect);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.fileSelect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pathCompress);
            this.Controls.Add(this.execBtn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button execBtn;
        private System.Windows.Forms.Label pathCompress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button pathSelect;
        private System.Windows.Forms.Label pathSong;
        private System.Windows.Forms.TextBox fileText;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}