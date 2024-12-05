namespace ContactsApp.View
{
	partial class ContactForm
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
            ContactPanel = new Panel();
            AddPhotoButton = new PictureBox();
            DateOfBirthDateTimePicker = new DateTimePicker();
            FooterPanel = new Panel();
            OKButton = new Button();
            CancelButton = new Button();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            ContactPictureBox = new PictureBox();
            ButtonClesr = new Button();
            ContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddPhotoButton).BeginInit();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContactPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ContactPanel
            // 
            ContactPanel.Controls.Add(AddPhotoButton);
            ContactPanel.Controls.Add(DateOfBirthDateTimePicker);
            ContactPanel.Controls.Add(FooterPanel);
            ContactPanel.Controls.Add(VKTextBox);
            ContactPanel.Controls.Add(VKLabel);
            ContactPanel.Controls.Add(DateOfBirthLabel);
            ContactPanel.Controls.Add(PhoneNumberTextBox);
            ContactPanel.Controls.Add(PhoneNumberLabel);
            ContactPanel.Controls.Add(EmailTextBox);
            ContactPanel.Controls.Add(EmailLabel);
            ContactPanel.Controls.Add(FullNameTextBox);
            ContactPanel.Controls.Add(FullNameLabel);
            ContactPanel.Controls.Add(ContactPictureBox);
            ContactPanel.Dock = DockStyle.Fill;
            ContactPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ContactPanel.Location = new Point(0, 0);
            ContactPanel.Margin = new Padding(3, 3, 15, 3);
            ContactPanel.Name = "ContactPanel";
            ContactPanel.Size = new Size(533, 341);
            ContactPanel.TabIndex = 2;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.Location = new Point(12, 113);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(100, 32);
            AddPhotoButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddPhotoButton.TabIndex = 14;
            AddPhotoButton.TabStop = false;
            AddPhotoButton.MouseEnter += AddPhotoButton_MouseEnter;
            AddPhotoButton.MouseLeave += AddPhotoButton_MouseLeave;
            // 
            // DateOfBirthDateTimePicker
            // 
            DateOfBirthDateTimePicker.Location = new Point(118, 194);
            DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            DateOfBirthDateTimePicker.Size = new Size(175, 23);
            DateOfBirthDateTimePicker.TabIndex = 13;
            DateOfBirthDateTimePicker.ValueChanged += DateOfBirthDateTimePicker_ValueChanged;
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.WhiteSmoke;
            FooterPanel.Controls.Add(ButtonClesr);
            FooterPanel.Controls.Add(OKButton);
            FooterPanel.Controls.Add(CancelButton);
            FooterPanel.Location = new Point(0, 295);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(525, 46);
            FooterPanel.TabIndex = 12;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(358, 12);
            OKButton.Margin = new Padding(0, 0, 9, 0);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(73, 22);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(440, 12);
            CancelButton.Margin = new Padding(0, 13, 14, 13);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(73, 22);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // VKTextBox
            // 
            VKTextBox.BorderStyle = BorderStyle.FixedSingle;
            VKTextBox.Location = new Point(118, 248);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(175, 23);
            VKTextBox.TabIndex = 10;
            VKTextBox.TextChanged += VKTextBox_TextChanged;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(118, 230);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(24, 15);
            VKLabel.TabIndex = 9;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(118, 176);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(93, 15);
            DateOfBirthLabel.TabIndex = 7;
            DateOfBirthLabel.Text = "Дата рождения:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumberTextBox.Location = new Point(118, 140);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(175, 23);
            PhoneNumberTextBox.TabIndex = 6;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            PhoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(118, 122);
            PhoneNumberLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(48, 15);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "Номер:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextBox.Location = new Point(118, 86);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(403, 23);
            EmailTextBox.TabIndex = 4;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(118, 68);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextBox.Location = new Point(118, 32);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(403, 23);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(118, 14);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(37, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "ФИО:";
            FullNameLabel.Click += FullNameLabel_Click;
            // 
            // ContactPictureBox
            // 
            ContactPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            ContactPictureBox.Location = new Point(12, 12);
            ContactPictureBox.Margin = new Padding(12, 12, 3, 3);
            ContactPictureBox.Name = "ContactPictureBox";
            ContactPictureBox.Size = new Size(100, 100);
            ContactPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ContactPictureBox.TabIndex = 0;
            ContactPictureBox.TabStop = false;
            // 
            // ButtonClesr
            // 
            ButtonClesr.Location = new Point(276, 12);
            ButtonClesr.Margin = new Padding(0, 0, 9, 0);
            ButtonClesr.Name = "ButtonClesr";
            ButtonClesr.Size = new Size(73, 22);
            ButtonClesr.TabIndex = 2;
            ButtonClesr.Text = "Очистить";
            ButtonClesr.UseVisualStyleBackColor = true;
            ButtonClesr.Click += button1_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 341);
            Controls.Add(ContactPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ContactForm";
            ShowIcon = false;
            ContactPanel.ResumeLayout(false);
            ContactPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddPhotoButton).EndInit();
            FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContactPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContactPanel;
		private TextBox VKTextBox;
		private Label VKLabel;
		private Label DateOfBirthLabel;
		private TextBox PhoneNumberTextBox;
		private Label PhoneNumberLabel;
		private TextBox EmailTextBox;
		private Label EmailLabel;
		private TextBox FullNameTextBox;
		private Label FullNameLabel;
		private PictureBox ContactPictureBox;
		private DateTimePicker DateOfBirthDateTimePicker;
		private Panel FooterPanel;
		private Button OKButton;
		private Button CancelButton;
		private PictureBox AddPhotoButton;
        private Button ButtonClesr;
    }
}