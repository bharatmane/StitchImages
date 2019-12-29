namespace ImageStitch
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstImages = new System.Windows.Forms.ListBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStitch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRootFolderPath = new System.Windows.Forms.TextBox();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnAllFOlders = new System.Windows.Forms.Button();
            this.pbImageStitching = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinalFolderLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(578, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstImages
            // 
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Location = new System.Drawing.Point(293, 73);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(265, 550);
            this.lstImages.TabIndex = 1;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(293, 44);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(227, 20);
            this.txtFolder.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(526, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select folder to pick the images";
            // 
            // btnStitch
            // 
            this.btnStitch.Location = new System.Drawing.Point(293, 629);
            this.btnStitch.Name = "btnStitch";
            this.btnStitch.Size = new System.Drawing.Size(265, 23);
            this.btnStitch.TabIndex = 6;
            this.btnStitch.Text = "STITCH";
            this.btnStitch.UseVisualStyleBackColor = true;
            this.btnStitch.Click += new System.EventHandler(this.btnStitch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Parent folder to pick the folders";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRootFolderPath
            // 
            this.txtRootFolderPath.Location = new System.Drawing.Point(12, 44);
            this.txtRootFolderPath.Name = "txtRootFolderPath";
            this.txtRootFolderPath.Size = new System.Drawing.Size(227, 20);
            this.txtRootFolderPath.TabIndex = 7;
            // 
            // lstFolders
            // 
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.Location = new System.Drawing.Point(12, 73);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(265, 550);
            this.lstFolders.TabIndex = 10;
            this.lstFolders.SelectedIndexChanged += new System.EventHandler(this.lstFolders_SelectedIndexChanged);
            // 
            // btnAllFOlders
            // 
            this.btnAllFOlders.Location = new System.Drawing.Point(12, 630);
            this.btnAllFOlders.Name = "btnAllFOlders";
            this.btnAllFOlders.Size = new System.Drawing.Size(265, 23);
            this.btnAllFOlders.TabIndex = 11;
            this.btnAllFOlders.Text = "STITCH FOR ALL FOLDERS";
            this.btnAllFOlders.UseVisualStyleBackColor = true;
            this.btnAllFOlders.Click += new System.EventHandler(this.btnAllFOlders_Click);
            // 
            // pbImageStitching
            // 
            this.pbImageStitching.Location = new System.Drawing.Point(578, 630);
            this.pbImageStitching.Name = "pbImageStitching";
            this.pbImageStitching.Size = new System.Drawing.Size(769, 23);
            this.pbImageStitching.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Final Image Folder Location";
            // 
            // txtFinalFolderLocation
            // 
            this.txtFinalFolderLocation.Location = new System.Drawing.Point(578, 47);
            this.txtFinalFolderLocation.Name = "txtFinalFolderLocation";
            this.txtFinalFolderLocation.Size = new System.Drawing.Size(227, 20);
            this.txtFinalFolderLocation.TabIndex = 13;
            this.txtFinalFolderLocation.TextChanged += new System.EventHandler(this.txtFinalFolderLocation_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 665);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinalFolderLocation);
            this.Controls.Add(this.pbImageStitching);
            this.Controls.Add(this.btnAllFOlders);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRootFolderPath);
            this.Controls.Add(this.btnStitch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lstImages);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Stitcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRootFolderPath;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Button btnAllFOlders;
        private System.Windows.Forms.ProgressBar pbImageStitching;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinalFolderLocation;
    }
}

