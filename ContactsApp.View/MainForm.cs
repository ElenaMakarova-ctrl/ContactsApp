using ContactsApp.Model;
using System;
using System.ComponentModel.Design;

namespace ContactsApp.View;

public partial class MainForm : Form
{
    /// <summary>
    /// ������ ���� ���������.
    /// </summary>
    private Project _project;

    /// <summary>
    /// ������ ������������ ���������.
    /// </summary>
    private List<Contact> _displayedContacts = new List<Contact>();

    /// <summary>
    /// ����������� �����.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();

        try
        {
            _project = ProjectManager.Load();
            UpdateListBox();
            UpdateBirthdays();
        }
        catch
        {
            _project = new Project();
            UpdateBirthdays();
        }
    }

    /// <summary>
    /// �������� ������������ �������� � ListBox.
    /// </summary>
    private void UpdateListBox()
    {
        /*int index = ContactsListBox.SelectedIndex;
		Contact selectedContact = _displayedContacts[index];*/

        List<Contact> contacts = _project.FindContactsBySubstring(_project.Contacts, FindTextBox.Text);
        contacts = _project.SortContactsByFullName(contacts);
        _displayedContacts.Clear();
        _displayedContacts.AddRange(contacts);
        ContactsListBox.Items.Clear();
        foreach (Contact contact in _displayedContacts)
        {
            ContactsListBox.Items.Add(contact.FullName);
        }
    }

    /// <summary>
    /// �������� ������������ �� ������ ������ �������.
    /// </summary>
    private void UpdateSelectedContact(int index)
    {
        Contact contactToShow = _displayedContacts[index];
        FullNameTextBox.Text = contactToShow.FullName;
        EmailTextBox.Text = contactToShow.Email;
        PhoneNumberTextBox.Text = contactToShow.PhoneNumber;
        DateOfBirthTextBox.Text = contactToShow.DateOfBirth.ToString("d");
        VKTextBox.Text = contactToShow.VKId;
    }

    /// <summary>
    /// ������� ���������� �����������, ������������
    /// ������ ���������� ��������.
    /// </summary>
    private void ClearSelectedContact()
    {
        FullNameTextBox.Text = "";
        EmailTextBox.Text = "";
        PhoneNumberTextBox.Text = "";
        DateOfBirthTextBox.Text = "";
        VKTextBox.Text = "";
    }

    /// <summary>
    /// ����������� �������.
    /// </summary>
    /// <param name="index">������ �������������� ��������.</param>
    private void EditContact(int index)
    {
        Contact contactToEdit = _displayedContacts[index];

        var contactForm = new ContactForm();
        contactForm.Contact = (Contact)contactToEdit.Clone();
        DialogResult result = contactForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            Contact updatedContact = contactForm.Contact;
            int projectIndex = _project.IndexOf(contactToEdit);
            _project[projectIndex] = updatedContact;

            ProjectManager.Save(_project);
            UpdateListBox();
            ClearSelectedContact();
        }
    }

    /// <summary>
    /// ��������� ����������� � ���� ��������� ���������.
    /// </summary>
    private void UpdateBirthdays()
    {
        List<Contact> result = _project.FindContactsByBirthDay();

        if (result.Count == 0)
        {
            NotificationSurnamesLabel.Text = "";
            return;
        }

        var surnames = result.Select(contact => contact.FullName.Split(" ")[0]).ToList();
        var count = Math.Min(result.Count, 3);
        var fullMessage = string.Join(", ", surnames.Take(count));

        if (result.Count > 3)
        {
            fullMessage += " � ��.";
        }

        NotificationSurnamesLabel.Text = fullMessage;
    }

    /// <summary>
    /// ��������� ������������ ������ ��������.
    /// </summary>
    private void UpdateSelectedIndexChanged()
    {
        if (ContactsListBox.SelectedIndex == -1)
        {
            ClearSelectedContact();
        }
        else
        {
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }
    }

    /// <summary>
    /// �������� ����� ��� ���������� ������ ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddContactButton_Click(object sender, EventArgs e)
    {
        Contact newContact = new Contact();
        var contactForm = new ContactForm();
        contactForm.Contact = newContact;
        DialogResult result = contactForm.ShowDialog();

        if (result == DialogResult.OK)
        {
            _project.AddContact(newContact);

            ProjectManager.Save(_project);
            UpdateListBox();
            UpdateBirthdays();
        }
    }

    /// <summary>
    /// �������� ����� ��� �������������� ������� ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EditContactButton_Click(object sender, EventArgs e)
    {
        try
        {
            int selectedIndex = ContactsListBox.SelectedIndex;
            EditContact(selectedIndex);
            UpdateBirthdays();
        }
        catch
        {
            MessageBox.Show("�������� ������� ��� ��������������",
                "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    /// <summary>
    /// ������� ��������� �������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RemoveContactButton_Click(object sender, EventArgs e)
    {
        try
        {
            Contact contactToDelete = _displayedContacts[ContactsListBox.SelectedIndex];

            DialogResult result = MessageBox.Show($"Do you really want to remove {contactToDelete.FullName}?",
                "Remove element",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.RemoveContact(contactToDelete);
                UpdateListBox();
                if (ContactsListBox.Items.Count == 0)
                {
                    ClearSelectedContact();
                }
                ProjectManager.Save(_project);
                UpdateBirthdays();
            }
        }
        catch
        {
            MessageBox.Show("�������� ������� ��� ��������",
                "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    /// <summary>
    /// ��������� ���� �������� � ��������� ���� ��� ����������� �������
    /// ����� ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// ��������� ���� �������� � ��������� ���� ��� ����������� email ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// ��������� ���� �������� � ��������� ���� ��� ����������� 
    /// ������ �������� ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// ��������� ���� �������� � ��������� ���� ��� ����������� 
    /// ��� �������� ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// ��������� ���� �������� � ��������� ���� ��� ����������� 
    /// VK ID ��������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    /// <summary>
    /// �������� ����� �� ���������� ���������� � ���������
    /// ��� ������� F2.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F1)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }

    /// <summary>
    /// ��������� ����������� �� �����������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CloseNotificationButton_Click(object sender, EventArgs e)
    {
        NotificationPanel.Visible = false;
    }

    /// <summary>
    /// ������ ������������ ������� ��� ������
    /// ������� �������� � ������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateSelectedIndexChanged();
    }

    /// <summary>
    /// ��������� ������ ��������� � �����������
    /// � �������� ����������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FindTextBox_TextChanged(object sender, EventArgs e)
    {
        _displayedContacts = _project.FindContactsBySubstring(_project.Contacts, FindTextBox.Text);
        ContactsListBox.SelectedIndex = -1;
        UpdateListBox();
    }

    /// <summary>
    /// ��������� ����� ����� �� ������������ �����
    /// ����� �� ����������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Do you really want to exit?",
            "Close app?", MessageBoxButtons.OKCancel);

        if (result != DialogResult.OK)
        {
            ProjectManager.Save(_project);
            e.Cancel = true;
        }
    }

    /// <summary>
    /// �������� ���� ������ ���������� ��������
    /// ��� ��������� �� ��� �������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddContactButton_MouseEnter(object sender, EventArgs e)
    {
        AddContactButton.Image = Properties.Resources.add_contact_32x32;
        AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
    }

    /// <summary>
    /// �������� ���� ������ ���������� ��������, �����
    /// ������ ������� �� ������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddContactButton_MouseLeave(object sender, EventArgs e)
    {
        AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
        AddContactButton.BackColor = Color.White;
    }

    /// <summary>
    /// ������ ���� ������ �������� �������� ��� ���������
    /// �� ��� �������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
    {
        RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
        RemoveContactButton.BackColor = Color.FromArgb(250, 245, 245);
    }

    /// <summary>
    /// ������ ���� ������ �������� �������� ��� ��������� �� ��� �������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
    {
        RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
        RemoveContactButton.BackColor = Color.White;
    }

    /// <summary>
    /// ������ ���� ������ �������������� �������� ��� ���������
    /// �� ��� �������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EditContactButton_MouseEnter(object sender, EventArgs e)
    {
        EditContactButton.Image = Properties.Resources.edit_contact_32x32;
        EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
    }

    /// <summary>
    /// ������ ���� ������ �������������� �������� ��� ��������� �� ��� �������.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EditContactButton_MouseLeave(object sender, EventArgs e)
    {
        EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
        EditContactButton.BackColor = Color.White;
    }
    /// ��������� ���� � ���������� � ������� �����
    private void Icon_Click(object sender, EventArgs e)
    {
        AboutForm aboutForm = new AboutForm();
        aboutForm.Show(); // ����������� ��������� ������ aboutForm ��� ������ ������ Show()
    }

    private void NotificationSurnamesLabel_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
