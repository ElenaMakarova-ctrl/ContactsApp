using System.Security.AccessControl;

namespace ContactsApp.Model;

/// <summary>
/// Описывает контакт.
/// </summary>
public class Contact : ICloneable
{
	/// <summary>
	/// Паттерн для валидации email.
	/// Пример правильного email: dshkg@mail.ru
	/// </summary>
	private const string _emailRegex = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

	/// <summary>
	/// Паттерн для валидации номера телефона.
	/// Примеры правильного номера телефона: 
	/// +79261234567
	/// 89261234567
	/// 79261234567
	/// +7 926 123 45 67
	/// 8(926)123-45-67
	/// 123-45-67
	/// 9261234567
	/// 79261234567
	/// (495)1234567
	/// (495) 123 45 67
	/// 89261234567
	/// 8-926-123-45-67
	/// 8 927 1234 234
	/// 8 927 12 12 888
	/// 8 927 12 555 12
	/// 8 927 123 8 123
	/// </summary>
	private const string _phoneNumberRegex = "^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$";

	/// <summary>
	/// Полное имя контакта.
	/// </summary>
	private string _fullName;

	/// <summary>
	/// E-mail контакта.
	/// </summary>
	private string _email;

	/// <summary>
	/// Номер телефона контакта.
	/// </summary>
	private string _phoneNumber;

	/// <summary>
	/// Дата рождения контакта.
	/// </summary>
	private DateTime _dateOfBirth = DateTime.Today;

	/// <summary>
	/// ID ВКонтакте контакта.
	/// </summary>
	private string _vkId;

	/// <summary>
	/// Создает копию контакта.
	/// </summary>
	/// <returns>Копия контакта.</returns>
	public object Clone()
	{
		return MemberwiseClone();
	}

	/// <summary>
	/// Возвращает или задает полное имя контакта.
	/// </summary>
	public string FullName
	{
		get
		{
			return _fullName;
		}
		set
		{
			ContactValidator.CheckLengthOfString(value, 100, "Полное имя");
			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
			string titleCase = textInfo.ToTitleCase(value);
			_fullName = titleCase;
		}
	}

	/// <summary>
	/// Возвращает или задает E-mail контакта.
	/// </summary>
	public string Email
	{
		get
		{
			return _email;
		}
		set
		{
			ContactValidator.CheckLengthOfString(value, 100, "Email");
			ContactValidator.CheckValueOnRegexPattern(value, _emailRegex, "Email");
			_email = value;
		}
	}

	/// <summary>
	/// Возвращает или задает телефонный номер контакта.
	/// </summary>
	public string PhoneNumber
	{
		get
		{
			return _phoneNumber;
		}
		set
		{
			ContactValidator.CheckValueOnRegexPattern(value, _phoneNumberRegex, "Номер телефона");
			_phoneNumber = value;
		}
	}

	/// <summary>
	/// Возвращает или задает день рождения контакта.
	/// </summary>
	public DateTime DateOfBirth
	{
		get
		{
			return _dateOfBirth;
		}
		set
		{
			ContactValidator.CheckMinIntValue(value.Year, 1900, "Год рождения");

            var now = DateTime.Now;

            // Проверяем, что дата рождения не позже текущей даты
            if (value > now)
            {
                var message = "Дата рождения не может быть больше текущей даты";
                throw new ArgumentException(message);
            }

            _dateOfBirth = value;
		}
	}


	/// <summary>
	/// Возвращает или задает ID Вконтакте контакта.  
	/// </summary>
	public string VKId
	{
		get
		{
			return _vkId;
		}
		set
		{
			ContactValidator.CheckLengthOfString(value, 50, "VKId");
			_vkId = value;
		}
	}
}
