using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model;

/// <summary>
/// Класс рандомной генереации контакта.
/// </summary>
static public class ContactFactory
{
	/// <summary>
	/// Массив полных имен.
	/// </summary>
	private static string[] fullNames = {
			"Сеченов Владислав", "Иван Иванов", "Кирилл Сидоров",
			"Алена Сергеева", "Евгений Дмитриев", "Роман Романов",
			"Ирина Попова", "Павел Семёнов", "Семён Кузнецов"
		};

	/// <summary>
	/// Массив email.
	/// </summary>
	private static string[] emails = {
			"adh@mail.ru", "bjcksd@mail.ru", "cbhds@mail.ru",
			"bhcge@mail.ru", "vbyuru@mail.ru", "b3h2@mail.ru",
			"bviriroir@mail.ru", "vbudh34@mail.ru", "vbhf52@mail.ru"
		};

	/// <summary>
	/// Созадет контакт с рандомными данными.
	/// </summary>
	/// <returns>Контакт с рандомными данными.</returns>
	static public Contact CreateContact()
	{
		Contact newContact = new Contact();

		var rand = new Random();
		int fullNameIndex = rand.Next(fullNames.Length);
		int emailIndex = rand.Next(emails.Length);

		newContact.FullName = fullNames[fullNameIndex];
		newContact.Email = emails[emailIndex];
		newContact.VKId = rand.Next(100000).ToString();
		newContact.PhoneNumber =
			"+7 (" + rand.Next(100, 999).ToString() + ") "
			+ rand.Next(100, 999).ToString() + "-"
			+ rand.Next(10, 99).ToString() + "-"
			+ rand.Next(10, 99).ToString();
		newContact.DateOfBirth = DateTime.Today;

		return newContact;
	}
}
