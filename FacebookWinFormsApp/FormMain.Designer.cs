namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.albumsTitle = new System.Windows.Forms.Label();
            this.musicRec = new BasicFacebookFeatures.RecommendationUserControl();
            this.booksRec = new BasicFacebookFeatures.RecommendationUserControl();
            this.moviesAndTVShowsRec = new BasicFacebookFeatures.RecommendationUserControl();
            this.recommendationTitle = new System.Windows.Forms.Label();
            this.leftAlbumButton = new System.Windows.Forms.Button();
            this.stopProfileAlbumButton = new System.Windows.Forms.Button();
            this.startProfileAlbumButton = new System.Windows.Forms.Button();
            this.postStatusButton = new System.Windows.Forms.Button();
            this.postStatusListBox = new System.Windows.Forms.TextBox();
            this.postStatusTitle = new System.Windows.Forms.Label();
            this.biographyTextBox = new System.Windows.Forms.TextBox();
            this.biographyTitle = new System.Windows.Forms.Label();
            this.likedPagePictureBox = new System.Windows.Forms.PictureBox();
            this.likedPagesListBox = new System.Windows.Forms.ListBox();
            this.likedPagesTitle = new System.Windows.Forms.Label();
            this.albumPictureBox = new System.Windows.Forms.PictureBox();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.rightAlbumButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Location = new System.Drawing.Point(1416, 14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(126, 44);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.UseWaitCursor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.buttonLogout.Enabled = false;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Location = new System.Drawing.Point(1416, 66);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(126, 44);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.UseWaitCursor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 53;
            this.label1.UseWaitCursor = true;
            this.label1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1564, 716);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.albumListBox);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.albumsTitle);
            this.tabPage1.Controls.Add(this.musicRec);
            this.tabPage1.Controls.Add(this.booksRec);
            this.tabPage1.Controls.Add(this.moviesAndTVShowsRec);
            this.tabPage1.Controls.Add(this.recommendationTitle);
            this.tabPage1.Controls.Add(this.leftAlbumButton);
            this.tabPage1.Controls.Add(this.stopProfileAlbumButton);
            this.tabPage1.Controls.Add(this.startProfileAlbumButton);
            this.tabPage1.Controls.Add(this.postStatusButton);
            this.tabPage1.Controls.Add(this.postStatusListBox);
            this.tabPage1.Controls.Add(this.postStatusTitle);
            this.tabPage1.Controls.Add(this.biographyTextBox);
            this.tabPage1.Controls.Add(this.biographyTitle);
            this.tabPage1.Controls.Add(this.likedPagePictureBox);
            this.tabPage1.Controls.Add(this.likedPagesListBox);
            this.tabPage1.Controls.Add(this.likedPagesTitle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.rightAlbumButton);
            this.tabPage1.Controls.Add(this.albumPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1556, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(6, 8);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(148, 122);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.UseWaitCursor = true;
            // 
            // albumsTitle
            // 
            this.albumsTitle.AutoSize = true;
            this.albumsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.albumsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.albumsTitle.Location = new System.Drawing.Point(956, 312);
            this.albumsTitle.Name = "albumsTitle";
            this.albumsTitle.Size = new System.Drawing.Size(71, 24);
            this.albumsTitle.TabIndex = 56;
            this.albumsTitle.Text = "albums";
            this.albumsTitle.UseWaitCursor = true;
            this.albumsTitle.Visible = false;
            // 
            // musicRec
            // 
            this.musicRec.BackColor = System.Drawing.Color.Transparent;
            this.musicRec.Location = new System.Drawing.Point(405, 454);
            this.musicRec.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.musicRec.Name = "musicRec";
            this.musicRec.Size = new System.Drawing.Size(441, 155);
            this.musicRec.TabIndex = 122;
            this.musicRec.Title = "Music";
            this.musicRec.UseWaitCursor = true;
            this.musicRec.Visible = false;
            // 
            // booksRec
            // 
            this.booksRec.BackColor = System.Drawing.Color.Transparent;
            this.booksRec.Location = new System.Drawing.Point(405, 268);
            this.booksRec.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.booksRec.Name = "booksRec";
            this.booksRec.Size = new System.Drawing.Size(441, 170);
            this.booksRec.TabIndex = 121;
            this.booksRec.Title = "Books";
            this.booksRec.UseWaitCursor = true;
            this.booksRec.Visible = false;
            // 
            // moviesAndTVShowsRec
            // 
            this.moviesAndTVShowsRec.BackColor = System.Drawing.Color.Transparent;
            this.moviesAndTVShowsRec.Location = new System.Drawing.Point(405, 79);
            this.moviesAndTVShowsRec.Margin = new System.Windows.Forms.Padding(4);
            this.moviesAndTVShowsRec.Name = "moviesAndTVShowsRec";
            this.moviesAndTVShowsRec.Size = new System.Drawing.Size(441, 175);
            this.moviesAndTVShowsRec.TabIndex = 120;
            this.moviesAndTVShowsRec.Title = "Movies And Tv Shows";
            this.moviesAndTVShowsRec.UseWaitCursor = true;
            this.moviesAndTVShowsRec.Visible = false;
            // 
            // recommendationTitle
            // 
            this.recommendationTitle.AutoSize = true;
            this.recommendationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.recommendationTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.recommendationTitle.Location = new System.Drawing.Point(401, 27);
            this.recommendationTitle.Name = "recommendationTitle";
            this.recommendationTitle.Size = new System.Drawing.Size(223, 24);
            this.recommendationTitle.TabIndex = 80;
            this.recommendationTitle.Text = "Recommendation Corner";
            this.recommendationTitle.UseWaitCursor = true;
            this.recommendationTitle.Visible = false;
            // 
            // leftAlbumButton
            // 
            this.leftAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.leftAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftAlbumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.leftAlbumButton.Location = new System.Drawing.Point(1218, 616);
            this.leftAlbumButton.Name = "leftAlbumButton";
            this.leftAlbumButton.Size = new System.Drawing.Size(49, 57);
            this.leftAlbumButton.TabIndex = 55;
            this.leftAlbumButton.Text = "<=";
            this.leftAlbumButton.UseVisualStyleBackColor = false;
            this.leftAlbumButton.UseWaitCursor = true;
            this.leftAlbumButton.Visible = false;
            this.leftAlbumButton.Click += new System.EventHandler(this.leftAlbumButton_Click);
            // 
            // stopProfileAlbumButton
            // 
            this.stopProfileAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.stopProfileAlbumButton.Enabled = false;
            this.stopProfileAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopProfileAlbumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.stopProfileAlbumButton.Location = new System.Drawing.Point(160, 71);
            this.stopProfileAlbumButton.Name = "stopProfileAlbumButton";
            this.stopProfileAlbumButton.Size = new System.Drawing.Size(146, 46);
            this.stopProfileAlbumButton.TabIndex = 78;
            this.stopProfileAlbumButton.Text = "press to stop profile album";
            this.stopProfileAlbumButton.UseVisualStyleBackColor = false;
            this.stopProfileAlbumButton.UseWaitCursor = true;
            this.stopProfileAlbumButton.Visible = false;
            this.stopProfileAlbumButton.Click += new System.EventHandler(this.stopProfileButton_Click);
            // 
            // startProfileAlbumButton
            // 
            this.startProfileAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.startProfileAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startProfileAlbumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startProfileAlbumButton.Location = new System.Drawing.Point(160, 14);
            this.startProfileAlbumButton.Name = "startProfileAlbumButton";
            this.startProfileAlbumButton.Size = new System.Drawing.Size(146, 51);
            this.startProfileAlbumButton.TabIndex = 75;
            this.startProfileAlbumButton.Text = "press to create new profile album";
            this.startProfileAlbumButton.UseVisualStyleBackColor = false;
            this.startProfileAlbumButton.UseWaitCursor = true;
            this.startProfileAlbumButton.Visible = false;
            this.startProfileAlbumButton.Click += new System.EventHandler(this.profileAlbumButton_Click);
            // 
            // postStatusButton
            // 
            this.postStatusButton.BackColor = System.Drawing.Color.Gainsboro;
            this.postStatusButton.Location = new System.Drawing.Point(1178, 199);
            this.postStatusButton.Name = "postStatusButton";
            this.postStatusButton.Size = new System.Drawing.Size(126, 57);
            this.postStatusButton.TabIndex = 70;
            this.postStatusButton.Text = "press here to post";
            this.postStatusButton.UseVisualStyleBackColor = false;
            this.postStatusButton.UseWaitCursor = true;
            this.postStatusButton.Visible = false;
            this.postStatusButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // postStatusListBox
            // 
            this.postStatusListBox.Location = new System.Drawing.Point(853, 41);
            this.postStatusListBox.Multiline = true;
            this.postStatusListBox.Name = "postStatusListBox";
            this.postStatusListBox.Size = new System.Drawing.Size(451, 152);
            this.postStatusListBox.TabIndex = 68;
            this.postStatusListBox.UseWaitCursor = true;
            this.postStatusListBox.Visible = false;
            // 
            // postStatusTitle
            // 
            this.postStatusTitle.AutoSize = true;
            this.postStatusTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.postStatusTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.postStatusTitle.Location = new System.Drawing.Point(849, 14);
            this.postStatusTitle.Name = "postStatusTitle";
            this.postStatusTitle.Size = new System.Drawing.Size(277, 24);
            this.postStatusTitle.TabIndex = 67;
            this.postStatusTitle.Text = "write status and post in your wall";
            this.postStatusTitle.UseWaitCursor = true;
            this.postStatusTitle.Visible = false;
            // 
            // biographyTextBox
            // 
            this.biographyTextBox.Location = new System.Drawing.Point(15, 183);
            this.biographyTextBox.Multiline = true;
            this.biographyTextBox.Name = "biographyTextBox";
            this.biographyTextBox.ReadOnly = true;
            this.biographyTextBox.Size = new System.Drawing.Size(230, 114);
            this.biographyTextBox.TabIndex = 63;
            this.biographyTextBox.UseWaitCursor = true;
            this.biographyTextBox.Visible = false;
            // 
            // biographyTitle
            // 
            this.biographyTitle.AutoSize = true;
            this.biographyTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.biographyTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.biographyTitle.Location = new System.Drawing.Point(15, 156);
            this.biographyTitle.Name = "biographyTitle";
            this.biographyTitle.Size = new System.Drawing.Size(95, 24);
            this.biographyTitle.TabIndex = 62;
            this.biographyTitle.Text = "Biography";
            this.biographyTitle.UseWaitCursor = true;
            this.biographyTitle.Visible = false;
            // 
            // likedPagePictureBox
            // 
            this.likedPagePictureBox.Location = new System.Drawing.Point(15, 516);
            this.likedPagePictureBox.Name = "likedPagePictureBox";
            this.likedPagePictureBox.Size = new System.Drawing.Size(228, 157);
            this.likedPagePictureBox.TabIndex = 61;
            this.likedPagePictureBox.TabStop = false;
            this.likedPagePictureBox.UseWaitCursor = true;
            this.likedPagePictureBox.Visible = false;
            // 
            // likedPagesListBox
            // 
            this.likedPagesListBox.FormattingEnabled = true;
            this.likedPagesListBox.ItemHeight = 22;
            this.likedPagesListBox.Location = new System.Drawing.Point(15, 377);
            this.likedPagesListBox.Name = "likedPagesListBox";
            this.likedPagesListBox.Size = new System.Drawing.Size(228, 136);
            this.likedPagesListBox.TabIndex = 60;
            this.likedPagesListBox.UseWaitCursor = true;
            this.likedPagesListBox.Visible = false;
            this.likedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.LikedPagesListBox_SelectedIndexChanged);
            // 
            // likedPagesTitle
            // 
            this.likedPagesTitle.AutoSize = true;
            this.likedPagesTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.likedPagesTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.likedPagesTitle.Location = new System.Drawing.Point(15, 350);
            this.likedPagesTitle.Name = "likedPagesTitle";
            this.likedPagesTitle.Size = new System.Drawing.Size(113, 24);
            this.likedPagesTitle.TabIndex = 59;
            this.likedPagesTitle.Text = "Liked Pages";
            this.likedPagesTitle.UseWaitCursor = true;
            this.likedPagesTitle.Visible = false;
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.Location = new System.Drawing.Point(1218, 339);
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.Size = new System.Drawing.Size(324, 269);
            this.albumPictureBox.TabIndex = 58;
            this.albumPictureBox.TabStop = false;
            this.albumPictureBox.UseWaitCursor = true;
            // 
            // albumListBox
            // 
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.ItemHeight = 22;
            this.albumListBox.Location = new System.Drawing.Point(960, 339);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(252, 334);
            this.albumListBox.TabIndex = 57;
            this.albumListBox.UseWaitCursor = true;
            this.albumListBox.Visible = false;
            this.albumListBox.SelectedIndexChanged += new System.EventHandler(this.albumListBox_SelectedIndexChanged);
            // 
            // rightAlbumButton
            // 
            this.rightAlbumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.rightAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAlbumButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rightAlbumButton.Location = new System.Drawing.Point(1493, 614);
            this.rightAlbumButton.Name = "rightAlbumButton";
            this.rightAlbumButton.Size = new System.Drawing.Size(49, 57);
            this.rightAlbumButton.TabIndex = 79;
            this.rightAlbumButton.Text = "=>";
            this.rightAlbumButton.UseVisualStyleBackColor = false;
            this.rightAlbumButton.UseWaitCursor = true;
            this.rightAlbumButton.Visible = false;
            this.rightAlbumButton.Click += new System.EventHandler(this.rightAlbumButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1902, 1007);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 716);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likedPagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox albumPictureBox;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.Label albumsTitle;
        private System.Windows.Forms.PictureBox likedPagePictureBox;
        private System.Windows.Forms.ListBox likedPagesListBox;
        private System.Windows.Forms.Label likedPagesTitle;
        private System.Windows.Forms.Label biographyTitle;
        private System.Windows.Forms.TextBox biographyTextBox;
        private System.Windows.Forms.TextBox postStatusListBox;
        private System.Windows.Forms.Label postStatusTitle;
        private System.Windows.Forms.Button postStatusButton;
        private System.Windows.Forms.Button startProfileAlbumButton;
        private System.Windows.Forms.Button stopProfileAlbumButton;
        private System.Windows.Forms.Button leftAlbumButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button rightAlbumButton;
        private System.Windows.Forms.Label recommendationTitle;
        private RecommendationUserControl moviesAndTVShowsRec;
        private RecommendationUserControl musicRec;
        private RecommendationUserControl booksRec;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

