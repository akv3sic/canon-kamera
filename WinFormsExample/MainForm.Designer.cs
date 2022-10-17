namespace WinFormsExample
{
    partial class MainForm
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
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.SavePhotosButton = new System.Windows.Forms.Button();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.TakePhotoButton = new System.Windows.Forms.Button();
            this.LiveViewGroupBox = new System.Windows.Forms.GroupBox();
            this.LiveViewPicBox2 = new System.Windows.Forms.PictureBox();
            this.LiveViewPicBox1 = new System.Windows.Forms.PictureBox();
            this.LiveViewButton = new System.Windows.Forms.Button();
            this.InitGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CameraListBox = new System.Windows.Forms.ListBox();
            this.SessionLabel = new System.Windows.Forms.Label();
            this.SessionButton = new System.Windows.Forms.Button();
            this.SaveFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SettingsGroupBox.SuspendLayout();
            this.LiveViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox1)).BeginInit();
            this.InitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.SavePhotosButton);
            this.SettingsGroupBox.Controls.Add(this.MainProgressBar);
            this.SettingsGroupBox.Controls.Add(this.SavePathTextBox);
            this.SettingsGroupBox.Controls.Add(this.BrowseButton);
            this.SettingsGroupBox.Controls.Add(this.TakePhotoButton);
            this.SettingsGroupBox.Enabled = false;
            this.SettingsGroupBox.Location = new System.Drawing.Point(204, 16);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsGroupBox.MinimumSize = new System.Drawing.Size(543, 194);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SettingsGroupBox.Size = new System.Drawing.Size(543, 194);
            this.SettingsGroupBox.TabIndex = 14;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            this.SettingsGroupBox.Enter += new System.EventHandler(this.SettingsGroupBox_Enter);
            // 
            // SavePhotosButton
            // 
            this.SavePhotosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePhotosButton.Location = new System.Drawing.Point(125, 31);
            this.SavePhotosButton.Margin = new System.Windows.Forms.Padding(4);
            this.SavePhotosButton.Name = "SavePhotosButton";
            this.SavePhotosButton.Size = new System.Drawing.Size(95, 59);
            this.SavePhotosButton.TabIndex = 9;
            this.SavePhotosButton.Text = "Save";
            this.SavePhotosButton.UseVisualStyleBackColor = true;
            this.SavePhotosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(8, 123);
            this.MainProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(173, 25);
            this.MainProgressBar.TabIndex = 8;
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.Enabled = false;
            this.SavePathTextBox.Location = new System.Drawing.Point(8, 155);
            this.SavePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(375, 22);
            this.SavePathTextBox.TabIndex = 6;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Enabled = false;
            this.BrowseButton.Location = new System.Drawing.Point(392, 151);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(132, 28);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // TakePhotoButton
            // 
            this.TakePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakePhotoButton.Location = new System.Drawing.Point(8, 31);
            this.TakePhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.TakePhotoButton.Name = "TakePhotoButton";
            this.TakePhotoButton.Size = new System.Drawing.Size(95, 59);
            this.TakePhotoButton.TabIndex = 2;
            this.TakePhotoButton.Text = "Shoot";
            this.TakePhotoButton.UseVisualStyleBackColor = true;
            this.TakePhotoButton.Click += new System.EventHandler(this.TakePhotoButton_Click);
            // 
            // LiveViewGroupBox
            // 
            this.LiveViewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewGroupBox.Controls.Add(this.LiveViewPicBox2);
            this.LiveViewGroupBox.Controls.Add(this.LiveViewPicBox1);
            this.LiveViewGroupBox.Controls.Add(this.LiveViewButton);
            this.LiveViewGroupBox.Enabled = false;
            this.LiveViewGroupBox.Location = new System.Drawing.Point(16, 218);
            this.LiveViewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.LiveViewGroupBox.Name = "LiveViewGroupBox";
            this.LiveViewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.LiveViewGroupBox.Size = new System.Drawing.Size(996, 506);
            this.LiveViewGroupBox.TabIndex = 13;
            this.LiveViewGroupBox.TabStop = false;
            this.LiveViewGroupBox.Text = "Live";
            // 
            // LiveViewPicBox2
            // 
            this.LiveViewPicBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewPicBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LiveViewPicBox2.Location = new System.Drawing.Point(507, 63);
            this.LiveViewPicBox2.Margin = new System.Windows.Forms.Padding(4);
            this.LiveViewPicBox2.Name = "LiveViewPicBox2";
            this.LiveViewPicBox2.Size = new System.Drawing.Size(480, 429);
            this.LiveViewPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LiveViewPicBox2.TabIndex = 3;
            this.LiveViewPicBox2.TabStop = false;
            // 
            // LiveViewPicBox1
            // 
            this.LiveViewPicBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewPicBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LiveViewPicBox1.Location = new System.Drawing.Point(13, 63);
            this.LiveViewPicBox1.Margin = new System.Windows.Forms.Padding(4);
            this.LiveViewPicBox1.Name = "LiveViewPicBox1";
            this.LiveViewPicBox1.Size = new System.Drawing.Size(480, 429);
            this.LiveViewPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LiveViewPicBox1.TabIndex = 1;
            this.LiveViewPicBox1.TabStop = false;
            this.LiveViewPicBox1.SizeChanged += new System.EventHandler(this.LiveViewPicBox_SizeChanged);
            // 
            // LiveViewButton
            // 
            this.LiveViewButton.Location = new System.Drawing.Point(11, 25);
            this.LiveViewButton.Margin = new System.Windows.Forms.Padding(4);
            this.LiveViewButton.Name = "LiveViewButton";
            this.LiveViewButton.Size = new System.Drawing.Size(93, 27);
            this.LiveViewButton.TabIndex = 2;
            this.LiveViewButton.Text = "Start Live";
            this.LiveViewButton.UseVisualStyleBackColor = true;
            this.LiveViewButton.Click += new System.EventHandler(this.LiveViewButton_Click);
            // 
            // InitGroupBox
            // 
            this.InitGroupBox.Controls.Add(this.RefreshButton);
            this.InitGroupBox.Controls.Add(this.CameraListBox);
            this.InitGroupBox.Controls.Add(this.SessionLabel);
            this.InitGroupBox.Controls.Add(this.SessionButton);
            this.InitGroupBox.Location = new System.Drawing.Point(16, 16);
            this.InitGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.InitGroupBox.Name = "InitGroupBox";
            this.InitGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.InitGroupBox.Size = new System.Drawing.Size(180, 194);
            this.InitGroupBox.TabIndex = 12;
            this.InitGroupBox.TabStop = false;
            this.InitGroupBox.Text = "Init";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(128, 156);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(41, 28);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "↻";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CameraListBox
            // 
            this.CameraListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CameraListBox.FormattingEnabled = true;
            this.CameraListBox.ItemHeight = 16;
            this.CameraListBox.Location = new System.Drawing.Point(11, 43);
            this.CameraListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CameraListBox.Name = "CameraListBox";
            this.CameraListBox.Size = new System.Drawing.Size(160, 100);
            this.CameraListBox.TabIndex = 6;
            // 
            // SessionLabel
            // 
            this.SessionLabel.AutoSize = true;
            this.SessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionLabel.Location = new System.Drawing.Point(8, 20);
            this.SessionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(134, 20);
            this.SessionLabel.TabIndex = 8;
            this.SessionLabel.Text = "No open session";
            // 
            // SessionButton
            // 
            this.SessionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionButton.Location = new System.Drawing.Point(8, 156);
            this.SessionButton.Margin = new System.Windows.Forms.Padding(4);
            this.SessionButton.Name = "SessionButton";
            this.SessionButton.Size = new System.Drawing.Size(112, 28);
            this.SessionButton.TabIndex = 7;
            this.SessionButton.Text = "Open Session";
            this.SessionButton.UseVisualStyleBackColor = true;
            this.SessionButton.Click += new System.EventHandler(this.SessionButton_Click);
            // 
            // SaveFolderBrowser
            // 
            this.SaveFolderBrowser.Description = "Save Images To...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 738);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.LiveViewGroupBox);
            this.Controls.Add(this.InitGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Canon SDK Tutorial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.LiveViewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox1)).EndInit();
            this.InitGroupBox.ResumeLayout(false);
            this.InitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button TakePhotoButton;
        private System.Windows.Forms.GroupBox LiveViewGroupBox;
        private System.Windows.Forms.PictureBox LiveViewPicBox1;
        private System.Windows.Forms.Button LiveViewButton;
        private System.Windows.Forms.GroupBox InitGroupBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListBox CameraListBox;
        private System.Windows.Forms.Label SessionLabel;
        private System.Windows.Forms.Button SessionButton;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowser;
        private System.Windows.Forms.PictureBox LiveViewPicBox2;
        private System.Windows.Forms.Button SavePhotosButton;
    }
}

