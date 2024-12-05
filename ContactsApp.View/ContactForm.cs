using ContactsApp.Model;
using System.Security.Policy;

namespace ContactsApp.View;

/// <summary>
/// Форма для редактирования/добавления контакта.
/// </summary>
public partial class ContactForm : Form
{
    /// <summary>
    /// Контакт.
    /// </summary>
    private Contact _contact = new Contact();

    /// <summary>
    /// Словарь ошибок.
    /// </summary>
    private Dictionary<string, string> _errorDictionary = new Dictionary<string, string>()
    {
        {nameof(Model.Contact.FullName), "" },
        {nameof(Model.Contact.Email), "" },
        {nameof(Model.Contact.PhoneNumber), "" },
        {nameof(Model.Contact.DateOfBirth), "" },
        {nameof(Model.Contact.VKId), "" }
    };

    /// <summary>
    /// Цвет элементов формы при отсутствии ошибок.
    /// </summary>
    private Color _defaultColor = Color.White;

    /// <summary>
    /// Цвет элементов формы при наличии ошибок.
    /// </summary>
    private Color _errorColor = Color.LightPink;

    /// <summary>
    /// Конструктор формы.
    /// </summary>
    public ContactForm()
    {
        InitializeComponent();

        UpdateForm();
    }

    /// <summary>
    /// Возвращает или задает контакт.
    /// </summary>
    public Contact Contact
    {
        get { return _contact; }
        set
        {
            if (value == null)
            {
                ClearForm();
            }
            else
            {
                _contact = value;
                UpdateForm();
            }
        }
    }

    /// <summary>
    /// Отображает данные контакта в форме.
    /// </summary>
    private void UpdateForm()
    {
        FullNameTextBox.Text = _contact.FullName;
        EmailTextBox.Text = _contact.Email;
        PhoneNumberTextBox.Text = _contact.PhoneNumber;
        DateOfBirthDateTimePicker.Value = _contact.DateOfBirth;
        VKTextBox.Text = _contact.VKId;
    }

    /// <summary>
    /// Присвоить данные из элементов формы в объект _contact.
    /// </summary>
    private void UpdateContact()
    {
        _contact.FullName = FullNameTextBox.Text;
        _contact.Email = EmailTextBox.Text;
        _contact.PhoneNumber = PhoneNumberTextBox.Text;
        _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
        _contact.VKId = VKTextBox.Text;
    }

    /// <summary>
    /// Очищает поля элементов на форме.
    /// </summary>
    private void ClearForm()
    {
        FullNameTextBox.Text = "";
        EmailTextBox.Text = "";
        PhoneNumberTextBox.Text = "";
        DateOfBirthDateTimePicker.Value = DateTime.Today;
        VKTextBox.Text = "";
    }

    /// <summary>
    /// Проверяет правильность введенных данных.
    /// </summary>
    /// <returns>true - ошибок нет, false - есть ошибки при введении данных.</returns>
    private bool CheckFormOnErrors()
    {
        string allErrors = "";

        foreach (var error in _errorDictionary)
        {
            if (error.Value != "")
            {
                allErrors += error.Value + "\n";
            }
        }

        if (allErrors != "")
        {
            MessageBox.Show(allErrors, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Запрещает вводить в поле для номера телефона все
    /// символы, кроме цифр и '-', '(', ')', ' ', '+'.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar >= '0')
            && (e.KeyChar <= '9')
            || (e.KeyChar == '-')
            || (e.KeyChar == '(')
            || (e.KeyChar == ')')
            || (e.KeyChar == ' ')
            || (e.KeyChar == (char)Keys.Back)
            || (e.KeyChar == '+'))
        {
            return;
        }
        e.Handled = true;
    }

    /// <summary>
    /// Присваивает введеное в поле полное им в соответствующее
    /// поле класса и валидирует его.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FullNameTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            _contact.FullName = FullNameTextBox.Text;
            FullNameTextBox.BackColor = _defaultColor;
            _errorDictionary[nameof(Contact.FullName)] = "";
        }
        catch (ArgumentException ex)
        {
            _errorDictionary[nameof(Contact.FullName)] = ex.Message;
            FullNameTextBox.BackColor = _errorColor;
        }
    }

    /// <summary>
    /// Присваивает введенный в поле email в соответствующее
    /// поле класса и валидирует его.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void EmailTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            _contact.Email = EmailTextBox.Text;
            EmailTextBox.BackColor = _defaultColor;
            _errorDictionary[nameof(Contact.Email)] = "";
        }
        catch (ArgumentException ex)
        {
            _errorDictionary[nameof(Contact.Email)] = ex.Message;
            EmailTextBox.BackColor = _errorColor;
        }
    }

    /// <summary>
    /// Присваивает введнный в поле номер телефона в соответствующее
    /// поле класса и валидирует его.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            PhoneNumberTextBox.BackColor = _defaultColor;
            _errorDictionary[nameof(Contact.PhoneNumber)] = "";
        }
        catch (ArgumentException ex)
        {
            _errorDictionary[nameof(Contact.PhoneNumber)] = ex.Message;
            PhoneNumberTextBox.BackColor = _errorColor;
        }
    }

    /// <summary>
    /// Присваивает введную в поле дату рождения в соответствующее
    /// поле класса и валидирует ее.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        try
        {
            _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
            _errorDictionary[nameof(Contact.DateOfBirth)] = "";
        }
        catch (ArgumentException ex)
        {
            _errorDictionary[nameof(Contact.DateOfBirth)] = ex.Message;
        }
    }

    /// <summary>
    /// Присваивает введный в поле VK ID в соответствующее
    /// поле класса и валидирует его.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void VKTextBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            _contact.VKId = VKTextBox.Text;
            VKTextBox.BackColor = _defaultColor;
            _errorDictionary[nameof(Contact.VKId)] = "";
        }
        catch (ArgumentException ex)
        {
            _errorDictionary[nameof(Contact.VKId)] = ex.Message;
            VKTextBox.BackColor = _errorColor;
        }
    }

    /// <summary>
    /// Создать/отредактировать контакт.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OKButton_Click(object sender, EventArgs e)
    {
        if (!CheckFormOnErrors())
        {
            return;
        }

        UpdateContact();

        DialogResult = DialogResult.OK;
        Close();
    }

    /// <summary>
    /// Отменяет добавление/редактирование контакта.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    /// <summary>
    /// Изменяет цвет картинки для добавления фотографии
    /// при наведении на нее курсора.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
    {
        AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
    }

    /// <summary>
    /// Изменяет цвет картинки для добавления фотографии
    /// при отведении от нее курсора.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
    {
        AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
    }

    private void FullNameLabel_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Очистка текста в текстовых полях
        FullNameTextBox.Text = ""; // Очистка поля для полного имени
        EmailTextBox.Text = ""; // Очистка поля для электронной почты
        PhoneNumberTextBox.Text = ""; // Очистка поля для телефонного номера
        VKTextBox.Text = ""; // Очистка поля для ссылки на VK

        // Альтернативный способ очистки текста в нескольких текстовых полях:
        // FullNameTextBox.Clear();
        // EmailTextBox.Clear();
        // PhoneNumberTextBox.Clear();
        // VKTextBox.Clear();
    }
}
