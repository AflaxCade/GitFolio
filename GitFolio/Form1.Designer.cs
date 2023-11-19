namespace GitFolio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMail = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.listBoxRepositories = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.Label();
            this.lblReposcount = new System.Windows.Forms.Label();
            this.lblBlog = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFollow = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBoxProfilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_bio = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.msgError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgRepo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgEmpty = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardProfile = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFetch = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCover = new System.Windows.Forms.Panel();
            this.msgNet = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cardProfile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCover.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(79, 128);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(0, 25);
            this.lblMail.TabIndex = 10;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.listBoxRepositories);
            this.guna2ShadowPanel1.Controls.Add(this.label9);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(1326, 45);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 3;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(550, 933);
            this.guna2ShadowPanel1.TabIndex = 15;
            // 
            // listBoxRepositories
            // 
            this.listBoxRepositories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRepositories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRepositories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRepositories.FormattingEnabled = true;
            this.listBoxRepositories.ItemHeight = 30;
            this.listBoxRepositories.Location = new System.Drawing.Point(41, 83);
            this.listBoxRepositories.Name = "listBoxRepositories";
            this.listBoxRepositories.Size = new System.Drawing.Size(479, 780);
            this.listBoxRepositories.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 46);
            this.label9.TabIndex = 7;
            this.label9.Text = "Repositories";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Socials";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(39, 863);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(157, 25);
            this.lblUpdate.TabIndex = 14;
            this.lblUpdate.Text = "Last updated at :";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(39, 806);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(114, 25);
            this.lblCreate.TabIndex = 13;
            this.lblCreate.Text = "Created at :";
            // 
            // txtCompany
            // 
            this.txtCompany.AutoSize = true;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(39, 578);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(108, 25);
            this.txtCompany.TabIndex = 12;
            this.txtCompany.Text = "Company :";
            // 
            // lblReposcount
            // 
            this.lblReposcount.AutoSize = true;
            this.lblReposcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReposcount.Location = new System.Drawing.Point(39, 749);
            this.lblReposcount.Name = "lblReposcount";
            this.lblReposcount.Size = new System.Drawing.Size(130, 25);
            this.lblReposcount.TabIndex = 11;
            this.lblReposcount.Text = "Repositories :";
            // 
            // lblBlog
            // 
            this.lblBlog.AutoSize = true;
            this.lblBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlog.Location = new System.Drawing.Point(79, 259);
            this.lblBlog.Name = "lblBlog";
            this.lblBlog.Size = new System.Drawing.Size(0, 25);
            this.lblBlog.TabIndex = 12;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(39, 692);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(97, 25);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 521);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 25);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name :";
            // 
            // lblFollow
            // 
            this.lblFollow.AutoSize = true;
            this.lblFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollow.Location = new System.Drawing.Point(39, 635);
            this.lblFollow.Name = "lblFollow";
            this.lblFollow.Size = new System.Drawing.Size(106, 25);
            this.lblFollow.TabIndex = 9;
            this.lblFollow.Text = "Followers :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(22, 482);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(505, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfilePicture.FillColor = System.Drawing.Color.LightGray;
            this.pictureBoxProfilePicture.ImageRotate = 0F;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(155, 36);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxProfilePicture.TabIndex = 5;
            this.pictureBoxProfilePicture.TabStop = false;
            this.pictureBoxProfilePicture.UseTransparentBackground = true;
            // 
            // lbl_bio
            // 
            this.lbl_bio.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bio.Location = new System.Drawing.Point(90, 309);
            this.lbl_bio.Name = "lbl_bio";
            this.lbl_bio.Size = new System.Drawing.Size(355, 169);
            this.lbl_bio.TabIndex = 6;
            this.lbl_bio.Text = "BIO";
            this.lbl_bio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GitFolio.Properties.Resources.web;
            this.pictureBox3.Location = new System.Drawing.Point(23, 252);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitFolio.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(23, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitter.Location = new System.Drawing.Point(79, 193);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(0, 25);
            this.lblTwitter.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(155, 272);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(225, 46);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgError
            // 
            this.msgError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgError.Caption = "Error";
            this.msgError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msgError.Parent = this;
            this.msgError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgError.Text = null;
            // 
            // msgRepo
            // 
            this.msgRepo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgRepo.Caption = "Rate Limit Exceeded";
            this.msgRepo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgRepo.Parent = this;
            this.msgRepo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgRepo.Text = null;
            // 
            // msgEmpty
            // 
            this.msgEmpty.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgEmpty.Caption = "Empty Username";
            this.msgEmpty.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgEmpty.Parent = this;
            this.msgEmpty.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgEmpty.Text = "Please enter a username before fetching user information.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GitFolio.Properties.Resources.twitter;
            this.pictureBox2.Location = new System.Drawing.Point(23, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // cardProfile
            // 
            this.cardProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cardProfile.BackColor = System.Drawing.Color.Transparent;
            this.cardProfile.Controls.Add(this.lblUpdate);
            this.cardProfile.Controls.Add(this.lblCreate);
            this.cardProfile.Controls.Add(this.txtCompany);
            this.cardProfile.Controls.Add(this.lblReposcount);
            this.cardProfile.Controls.Add(this.lblLocation);
            this.cardProfile.Controls.Add(this.lblName);
            this.cardProfile.Controls.Add(this.lblFollow);
            this.cardProfile.Controls.Add(this.guna2Separator1);
            this.cardProfile.Controls.Add(this.pictureBoxProfilePicture);
            this.cardProfile.Controls.Add(this.lbl_bio);
            this.cardProfile.Controls.Add(this.lblUsername);
            this.cardProfile.FillColor = System.Drawing.Color.White;
            this.cardProfile.Location = new System.Drawing.Point(45, 45);
            this.cardProfile.Name = "cardProfile";
            this.cardProfile.Radius = 3;
            this.cardProfile.ShadowColor = System.Drawing.Color.Transparent;
            this.cardProfile.Size = new System.Drawing.Size(550, 933);
            this.cardProfile.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.BorderRadius = 4;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(710, 130);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(504, 57);
            this.txtUsername.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblBlog);
            this.panel1.Controls.Add(this.lblTwitter);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(710, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 351);
            this.panel1.TabIndex = 7;
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFetch.BorderRadius = 4;
            this.btnFetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFetch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFetch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFetch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFetch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFetch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnFetch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFetch.ForeColor = System.Drawing.Color.White;
            this.btnFetch.Location = new System.Drawing.Point(710, 209);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(504, 57);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Search";
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // pnlCover
            // 
            this.pnlCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlCover.Controls.Add(this.cardProfile);
            this.pnlCover.Controls.Add(this.guna2ShadowPanel1);
            this.pnlCover.Controls.Add(this.panel1);
            this.pnlCover.Controls.Add(this.btnFetch);
            this.pnlCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCover.Location = new System.Drawing.Point(0, 0);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(1924, 1011);
            this.pnlCover.TabIndex = 11;
            // 
            // msgNet
            // 
            this.msgNet.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgNet.Caption = "No Internet";
            this.msgNet.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msgNet.Parent = this;
            this.msgNet.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgNet.Text = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1011);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlCover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitFolio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cardProfile.ResumeLayout(false);
            this.cardProfile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.ListBox listBoxRepositories;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label txtCompany;
        private System.Windows.Forms.Label lblReposcount;
        private System.Windows.Forms.Label lblBlog;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFollow;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label lbl_bio;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2MessageDialog msgError;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardProfile;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnFetch;
        private Guna.UI2.WinForms.Guna2MessageDialog msgRepo;
        private Guna.UI2.WinForms.Guna2MessageDialog msgEmpty;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNet;
    }
}

