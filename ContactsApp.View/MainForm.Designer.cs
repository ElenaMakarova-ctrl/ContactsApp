namespace ContactsApp.View
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ContactsAppTableLayoutPanel = new TableLayoutPanel();
            ContactsManagementPanel = new Panel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            AddContactButton = new PictureBox();
            EditContactButton = new PictureBox();
            RemoveContactButton = new PictureBox();
            FindContactLabel = new Label();
            FindTextBox = new TextBox();
            ContactsListBox = new ListBox();
            ContactDisplayPanel = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            NotificationPanel = new Panel();
            CloseNotificationButton = new Button();
            NotificationSurnamesLabel = new Label();
            NotficationBirthdayLabel = new Label();
            NotificationPictureBox = new PictureBox();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthTextBox = new TextBox();
            DateOfBirthLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            ContactPictureBox = new PictureBox();
            ContactsAppTableLayoutPanel.SuspendLayout();
            ContactsManagementPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).BeginInit();
            ContactDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            NotificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContactPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ContactsAppTableLayoutPanel
            // 
            ContactsAppTableLayoutPanel.ColumnCount = 2;
            ContactsAppTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 286F));
            ContactsAppTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ContactsAppTableLayoutPanel.Controls.Add(ContactsManagementPanel, 0, 0);
            ContactsAppTableLayoutPanel.Controls.Add(ContactDisplayPanel, 1, 0);
            ContactsAppTableLayoutPanel.Dock = DockStyle.Fill;
            ContactsAppTableLayoutPanel.Location = new Point(0, 0);
            ContactsAppTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            ContactsAppTableLayoutPanel.Name = "ContactsAppTableLayoutPanel";
            ContactsAppTableLayoutPanel.RowCount = 1;
            ContactsAppTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ContactsAppTableLayoutPanel.Size = new Size(903, 600);
            ContactsAppTableLayoutPanel.TabIndex = 0;
            // 
            // ContactsManagementPanel
            // 
            ContactsManagementPanel.Controls.Add(ButtonsTableLayoutPanel);
            ContactsManagementPanel.Controls.Add(FindContactLabel);
            ContactsManagementPanel.Controls.Add(FindTextBox);
            ContactsManagementPanel.Controls.Add(ContactsListBox);
            ContactsManagementPanel.Dock = DockStyle.Fill;
            ContactsManagementPanel.Location = new Point(3, 4);
            ContactsManagementPanel.Margin = new Padding(3, 4, 3, 4);
            ContactsManagementPanel.Name = "ContactsManagementPanel";
            ContactsManagementPanel.Size = new Size(280, 592);
            ContactsManagementPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonsTableLayoutPanel.ColumnCount = 3;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsTableLayoutPanel.Controls.Add(AddContactButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(EditContactButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(RemoveContactButton, 2, 0);
            ButtonsTableLayoutPanel.Location = new Point(3, 543);
            ButtonsTableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(272, 45);
            ButtonsTableLayoutPanel.TabIndex = 6;
            // 
            // AddContactButton
            // 
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.Location = new Point(0, 0);
            AddContactButton.Margin = new Padding(0);
            AddContactButton.Name = "AddContactButton";
            AddContactButton.Size = new Size(90, 45);
            AddContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddContactButton.TabIndex = 12;
            AddContactButton.TabStop = false;
            AddContactButton.Click += AddContactButton_Click;
            AddContactButton.MouseEnter += AddContactButton_MouseEnter;
            AddContactButton.MouseLeave += AddContactButton_MouseLeave;
            // 
            // EditContactButton
            // 
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.Location = new Point(90, 0);
            EditContactButton.Margin = new Padding(0);
            EditContactButton.Name = "EditContactButton";
            EditContactButton.Size = new Size(90, 45);
            EditContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            EditContactButton.TabIndex = 12;
            EditContactButton.TabStop = false;
            EditContactButton.Click += EditContactButton_Click;
            EditContactButton.MouseEnter += EditContactButton_MouseEnter;
            EditContactButton.MouseLeave += EditContactButton_MouseLeave;
            // 
            // RemoveContactButton
            // 
            RemoveContactButton.Dock = DockStyle.Fill;
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.Location = new Point(180, 0);
            RemoveContactButton.Margin = new Padding(0);
            RemoveContactButton.Name = "RemoveContactButton";
            RemoveContactButton.Size = new Size(92, 45);
            RemoveContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            RemoveContactButton.TabIndex = 12;
            RemoveContactButton.TabStop = false;
            RemoveContactButton.Click += RemoveContactButton_Click;
            RemoveContactButton.MouseEnter += RemoveContactButton_MouseEnter;
            RemoveContactButton.MouseLeave += RemoveContactButton_MouseLeave;
            // 
            // FindContactLabel
            // 
            FindContactLabel.AutoSize = true;
            FindContactLabel.Location = new Point(3, 7);
            FindContactLabel.Name = "FindContactLabel";
            FindContactLabel.Size = new Size(55, 20);
            FindContactLabel.TabIndex = 2;
            FindContactLabel.Text = "Поиск:";
            // 
            // FindTextBox
            // 
            FindTextBox.BorderStyle = BorderStyle.FixedSingle;
            FindTextBox.Location = new Point(62, 4);
            FindTextBox.Margin = new Padding(3, 4, 3, 4);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.RightToLeft = RightToLeft.No;
            FindTextBox.Size = new Size(213, 27);
            FindTextBox.TabIndex = 1;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // ContactsListBox
            // 
            ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.IntegralHeight = false;
            ContactsListBox.ItemHeight = 20;
            ContactsListBox.Location = new Point(4, 43);
            ContactsListBox.Margin = new Padding(3, 4, 3, 4);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(271, 499);
            ContactsListBox.TabIndex = 0;
            ContactsListBox.SelectedIndexChanged += ContactsListBox_SelectedIndexChanged;
            // 
            // ContactDisplayPanel
            // 
            ContactDisplayPanel.Controls.Add(label1);
            ContactDisplayPanel.Controls.Add(pictureBox2);
            ContactDisplayPanel.Controls.Add(NotificationPanel);
            ContactDisplayPanel.Controls.Add(VKTextBox);
            ContactDisplayPanel.Controls.Add(VKLabel);
            ContactDisplayPanel.Controls.Add(DateOfBirthTextBox);
            ContactDisplayPanel.Controls.Add(DateOfBirthLabel);
            ContactDisplayPanel.Controls.Add(PhoneNumberTextBox);
            ContactDisplayPanel.Controls.Add(PhoneNumberLabel);
            ContactDisplayPanel.Controls.Add(EmailTextBox);
            ContactDisplayPanel.Controls.Add(EmailLabel);
            ContactDisplayPanel.Controls.Add(FullNameTextBox);
            ContactDisplayPanel.Controls.Add(FullNameLabel);
            ContactDisplayPanel.Controls.Add(ContactPictureBox);
            ContactDisplayPanel.Dock = DockStyle.Fill;
            ContactDisplayPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactDisplayPanel.Location = new Point(289, 4);
            ContactDisplayPanel.Margin = new Padding(3, 4, 3, 4);
            ContactDisplayPanel.Name = "ContactDisplayPanel";
            ContactDisplayPanel.Size = new Size(611, 592);
            ContactDisplayPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(555, 499);
            label1.Margin = new Padding(3, 13, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 13;
            label1.Text = "Info";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.about_bluee;
            pictureBox2.Location = new Point(550, 523);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 49);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Icon_Click;
            // 
            // NotificationPanel
            // 
            NotificationPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NotificationPanel.BackColor = Color.FromArgb(245, 245, 255);
            NotificationPanel.Controls.Add(CloseNotificationButton);
            NotificationPanel.Controls.Add(NotificationSurnamesLabel);
            NotificationPanel.Controls.Add(NotficationBirthdayLabel);
            NotificationPanel.Controls.Add(NotificationPictureBox);
            NotificationPanel.Location = new Point(0, 492);
            NotificationPanel.Margin = new Padding(3, 4, 3, 4);
            NotificationPanel.Name = "NotificationPanel";
            NotificationPanel.Size = new Size(511, 88);
            NotificationPanel.TabIndex = 11;
            // 
            // CloseNotificationButton
            // 
            CloseNotificationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseNotificationButton.FlatAppearance.BorderSize = 0;
            CloseNotificationButton.FlatStyle = FlatStyle.Flat;
            CloseNotificationButton.Image = Properties.Resources.close_32x32;
            CloseNotificationButton.Location = new Point(471, 4);
            CloseNotificationButton.Margin = new Padding(3, 4, 3, 4);
            CloseNotificationButton.Name = "CloseNotificationButton";
            CloseNotificationButton.Size = new Size(37, 43);
            CloseNotificationButton.TabIndex = 3;
            CloseNotificationButton.UseVisualStyleBackColor = true;
            CloseNotificationButton.Click += CloseNotificationButton_Click;
            // 
            // NotificationSurnamesLabel
            // 
            NotificationSurnamesLabel.AutoSize = true;
            NotificationSurnamesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NotificationSurnamesLabel.ForeColor = Color.FromArgb(0, 144, 255);
            NotificationSurnamesLabel.Location = new Point(90, 51);
            NotificationSurnamesLabel.Name = "NotificationSurnamesLabel";
            NotificationSurnamesLabel.Size = new Size(247, 20);
            NotificationSurnamesLabel.TabIndex = 2;
            NotificationSurnamesLabel.Text = "Абакумов, Петров, Иванов и др.";
            // 
            // NotficationBirthdayLabel
            // 
            NotficationBirthdayLabel.AutoSize = true;
            NotficationBirthdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NotficationBirthdayLabel.ForeColor = Color.FromArgb(0, 144, 255);
            NotficationBirthdayLabel.Location = new Point(90, 31);
            NotficationBirthdayLabel.Name = "NotficationBirthdayLabel";
            NotficationBirthdayLabel.Size = new Size(166, 20);
            NotficationBirthdayLabel.TabIndex = 1;
            NotficationBirthdayLabel.Text = "Today is a Bitrhday of:";
            // 
            // NotificationPictureBox
            // 
            NotificationPictureBox.Image = Properties.Resources.info_48x48;
            NotificationPictureBox.Location = new Point(3, 4);
            NotificationPictureBox.Margin = new Padding(3, 4, 3, 4);
            NotificationPictureBox.Name = "NotificationPictureBox";
            NotificationPictureBox.Size = new Size(80, 93);
            NotificationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            NotificationPictureBox.TabIndex = 0;
            NotificationPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            VKTextBox.BorderStyle = BorderStyle.FixedSingle;
            VKTextBox.Location = new Point(125, 319);
            VKTextBox.Margin = new Padding(3, 4, 3, 4);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(200, 27);
            VKTextBox.TabIndex = 10;
            VKTextBox.KeyPress += VKTextBox_KeyPress;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(125, 295);
            VKLabel.Margin = new Padding(3, 13, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(30, 20);
            VKLabel.TabIndex = 9;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.BorderStyle = BorderStyle.FixedSingle;
            DateOfBirthTextBox.Location = new Point(125, 247);
            DateOfBirthTextBox.Margin = new Padding(3, 4, 3, 4);
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.Size = new Size(200, 27);
            DateOfBirthTextBox.TabIndex = 8;
            DateOfBirthTextBox.KeyPress += DateOfBirthTextBox_KeyPress;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(125, 223);
            DateOfBirthLabel.Margin = new Padding(3, 13, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(119, 20);
            DateOfBirthLabel.TabIndex = 7;
            DateOfBirthLabel.Text = "Дата рождения:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumberTextBox.Location = new Point(125, 175);
            PhoneNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(200, 27);
            PhoneNumberTextBox.TabIndex = 6;
            PhoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(125, 151);
            PhoneNumberLabel.Margin = new Padding(3, 13, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(72, 20);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Телефон:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextBox.Location = new Point(125, 103);
            EmailTextBox.Margin = new Padding(3, 4, 3, 4);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(200, 27);
            EmailTextBox.TabIndex = 4;
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(125, 79);
            EmailLabel.Margin = new Padding(3, 13, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(55, 20);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextBox.Location = new Point(125, 31);
            FullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(200, 27);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.KeyPress += FullNameTextBox_KeyPress;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(125, 7);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(45, 20);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "ФИО:";
            // 
            // ContactPictureBox
            // 
            ContactPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            ContactPictureBox.Location = new Point(3, 4);
            ContactPictureBox.Margin = new Padding(3, 4, 3, 4);
            ContactPictureBox.Name = "ContactPictureBox";
            ContactPictureBox.Size = new Size(114, 133);
            ContactPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ContactPictureBox.TabIndex = 0;
            ContactPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(903, 600);
            Controls.Add(ContactsAppTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "ContactsApp";
            FormClosing += MainForm_FormClosing;
            KeyDown += MainForm_KeyDown;
            ContactsAppTableLayoutPanel.ResumeLayout(false);
            ContactsManagementPanel.ResumeLayout(false);
            ContactsManagementPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AddContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).EndInit();
            ContactDisplayPanel.ResumeLayout(false);
            ContactDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            NotificationPanel.ResumeLayout(false);
            NotificationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotificationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContactPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ContactsAppTableLayoutPanel;
		private Panel ContactsManagementPanel;
		private Panel ContactDisplayPanel;
		private Label FindContactLabel;
		private TextBox FindTextBox;
		private ListBox ContactsListBox;
		private TableLayoutPanel ButtonsTableLayoutPanel;
		private PictureBox ContactPictureBox;
		private Label FullNameLabel;
		private TextBox FullNameTextBox;
		private Label EmailLabel;
		private TextBox PhoneNumberTextBox;
		private Label PhoneNumberLabel;
		private TextBox EmailTextBox;
		private TextBox VKTextBox;
		private Label VKLabel;
		private TextBox DateOfBirthTextBox;
		private Label DateOfBirthLabel;
		private Panel NotificationPanel;
		private PictureBox NotificationPictureBox;
		private Label NotficationBirthdayLabel;
		private Label NotificationSurnamesLabel;
		private Button CloseNotificationButton;
		private PictureBox RemoveContactButton;
		private PictureBox EditContactButton;
		private PictureBox AddContactButton;
        private PictureBox pictureBox2;
        private Label label1;
    }
}