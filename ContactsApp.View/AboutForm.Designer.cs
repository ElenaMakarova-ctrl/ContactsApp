namespace ContactsApp.View
{
	partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            ContactsAppLabel = new Label();
            VersionAppLabel = new Label();
            AuthorLabel = new Label();
            NameLabel = new Label();
            EmailLabel = new Label();
            EmailAdressLabel = new Label();
            GitHubLabel = new Label();
            FooterPanel = new Panel();
            OKButton = new Button();
            FormPanel = new Panel();
            GitHubLinkLabel = new LinkLabel();
            LicenseTextBox = new TextBox();
            FooterPanel.SuspendLayout();
            FormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            ContactsAppLabel.AutoSize = true;
            ContactsAppLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ContactsAppLabel.Location = new Point(12, 25);
            ContactsAppLabel.Margin = new Padding(3, 25, 3, 0);
            ContactsAppLabel.Name = "ContactsAppLabel";
            ContactsAppLabel.Size = new Size(139, 30);
            ContactsAppLabel.TabIndex = 0;
            ContactsAppLabel.Text = "ContactsApp";
            // 
            // VersionAppLabel
            // 
            VersionAppLabel.AutoSize = true;
            VersionAppLabel.Location = new Point(16, 55);
            VersionAppLabel.Margin = new Padding(7, 0, 3, 0);
            VersionAppLabel.Name = "VersionAppLabel";
            VersionAppLabel.Size = new Size(34, 15);
            VersionAppLabel.TabIndex = 1;
            VersionAppLabel.Text = "v. 1.0";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(16, 89);
            AuthorLabel.Margin = new Padding(7, 0, 3, 0);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(47, 15);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(119, 89);
            NameLabel.Margin = new Padding(56, 0, 3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(90, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Elena Makarova";
            NameLabel.Click += NameLabel_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(16, 114);
            EmailLabel.Margin = new Padding(7, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "E-mail:";
            // 
            // EmailAdressLabel
            // 
            EmailAdressLabel.AutoSize = true;
            EmailAdressLabel.Location = new Point(119, 114);
            EmailAdressLabel.Margin = new Padding(56, 0, 3, 0);
            EmailAdressLabel.Name = "EmailAdressLabel";
            EmailAdressLabel.Size = new Size(120, 15);
            EmailAdressLabel.TabIndex = 5;
            EmailAdressLabel.Text = "karlon44@gmail.com";
            // 
            // GitHubLabel
            // 
            GitHubLabel.AutoSize = true;
            GitHubLabel.Location = new Point(15, 139);
            GitHubLabel.Margin = new Padding(7, 10, 3, 0);
            GitHubLabel.Name = "GitHubLabel";
            GitHubLabel.Size = new Size(48, 15);
            GitHubLabel.TabIndex = 6;
            GitHubLabel.Text = "GitHub:";
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.WhiteSmoke;
            FooterPanel.Controls.Add(OKButton);
            FooterPanel.Location = new Point(0, 359);
            FooterPanel.Margin = new Padding(0, 3, 0, 0);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(511, 47);
            FooterPanel.TabIndex = 9;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(429, 21);
            OKButton.Margin = new Padding(0, 13, 9, 0);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(73, 22);
            OKButton.TabIndex = 14;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // FormPanel
            // 
            FormPanel.BorderStyle = BorderStyle.Fixed3D;
            FormPanel.Controls.Add(GitHubLinkLabel);
            FormPanel.Controls.Add(LicenseTextBox);
            FormPanel.Controls.Add(FooterPanel);
            FormPanel.Controls.Add(ContactsAppLabel);
            FormPanel.Controls.Add(VersionAppLabel);
            FormPanel.Controls.Add(GitHubLabel);
            FormPanel.Controls.Add(AuthorLabel);
            FormPanel.Controls.Add(EmailAdressLabel);
            FormPanel.Controls.Add(NameLabel);
            FormPanel.Controls.Add(EmailLabel);
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(0, 0);
            FormPanel.Margin = new Padding(3, 3, 5, 3);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(511, 406);
            FormPanel.TabIndex = 10;
            // 
            // GitHubLinkLabel
            // 
            GitHubLinkLabel.AutoSize = true;
            GitHubLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            GitHubLinkLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            GitHubLinkLabel.Location = new Point(119, 139);
            GitHubLinkLabel.Name = "GitHubLinkLabel";
            GitHubLinkLabel.Size = new Size(216, 15);
            GitHubLinkLabel.TabIndex = 12;
            GitHubLinkLabel.TabStop = true;
            GitHubLinkLabel.Text = "https://github.com/ElenaMakarova-ctrl";
            GitHubLinkLabel.LinkClicked += GitHubLinkLabel_LinkClicked;
            // 
            // LicenseTextBox
            // 
            LicenseTextBox.Location = new Point(12, 173);
            LicenseTextBox.Margin = new Padding(3, 19, 3, 3);
            LicenseTextBox.Multiline = true;
            LicenseTextBox.Name = "LicenseTextBox";
            LicenseTextBox.ScrollBars = ScrollBars.Vertical;
            LicenseTextBox.Size = new Size(487, 157);
            LicenseTextBox.TabIndex = 10;
            LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            LicenseTextBox.TextChanged += LicenseTextBox_TextChanged;
            LicenseTextBox.KeyPress += LicenseTextBox_KeyPress;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 406);
            Controls.Add(FormPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutForm";
            ShowIcon = false;
            FooterPanel.ResumeLayout(false);
            FormPanel.ResumeLayout(false);
            FormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label ContactsAppLabel;
		private Label VersionAppLabel;
		private Label AuthorLabel;
		private Label NameLabel;
		private Label EmailLabel;
		private Label EmailAdressLabel;
		private Label GitHubLabel;
		private Panel FooterPanel;
		private Panel FormPanel;
		private LinkLabel GitHubLinkLabel;
		private TextBox LicenseTextBox;
		private Button OKButton;
	}
}