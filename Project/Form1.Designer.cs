namespace Project
{
    partial class Form1
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
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.VideoStop = new System.Windows.Forms.Button();
            this.PlayVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxIpl1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl1.TabIndex = 4;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 14;
            // 
            // VideoStop
            // 
            this.VideoStop.Location = new System.Drawing.Point(338, 106);
            this.VideoStop.Name = "VideoStop";
            this.VideoStop.Size = new System.Drawing.Size(138, 77);
            this.VideoStop.TabIndex = 13;
            this.VideoStop.Text = "정지";
            this.VideoStop.UseVisualStyleBackColor = true;
            this.VideoStop.Click += new System.EventHandler(this.VideoStop_Click);
            // 
            // PlayVideo
            // 
            this.PlayVideo.Location = new System.Drawing.Point(338, 12);
            this.PlayVideo.Name = "PlayVideo";
            this.PlayVideo.Size = new System.Drawing.Size(138, 77);
            this.PlayVideo.TabIndex = 12;
            this.PlayVideo.Text = "시작";
            this.PlayVideo.UseVisualStyleBackColor = true;
            this.PlayVideo.Click += new System.EventHandler(this.PlayVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 260);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VideoStop);
            this.Controls.Add(this.PlayVideo);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button VideoStop;
        private System.Windows.Forms.Button PlayVideo;

    }
}