namespace ContactsApp.Model;

/// <summary>
/// Описывает проект.
/// </summary>
public class Project
{
	/// <summary>
	/// Список всех контактов, созданных в приложении.
	/// </summary>
	private List<Contact> _contacts;

	/// <summary>
	/// Конструктор по умолчанию.
	/// </summary>
	public Project()
	{
		_contacts = new List<Contact>();
	}

	/// <summary>
	/// Возвращает полный список контактов. 
	/// </summary>
	public List<Contact> Contacts
	{
		get { return _contacts; }
	}

	/// <summary>
	/// Возвращает или задает контакт по индексу.
	/// </summary>
	/// <param name="index">Индекс контакта.</param>
	public Contact this[int index]
	{
		get { return _contacts[index]; }
		set
		{
			_contacts[index] = value;
		}
	}

	/// <summary>
	/// Добавляет контакт в список.
	/// </summary>
	/// <param name="contact">Контакт, который нужно добавить.</param>
	public void AddContact(Contact contact)
	{
		_contacts.Add(contact);
	}

	/// <summary>
	/// Удаляет контакт из списка.
	/// </summary>
	/// <param name="index">Индекс контакта.</param>
	public void RemoveContact(Contact contact)
	{
		_contacts.Remove(contact);
	}

	/// <summary>
	/// Определяет индекс контакта в списке _contacts.
	/// </summary>
	/// <param name="contact">Контакт, индекс которого нужно определить.</param>
	/// <returns>Индекс контакта.</returns>
	public int IndexOf(Contact contact)
	{
		int index = _contacts.IndexOf(contact);
		return index;
	}

	/// <summary>
	/// Находит в списке контактов именинников.
	/// </summary>
	/// <returns>Список именнинков.</returns>
	public List<Contact> FindContactsByBirthDay()
	{
		List<Contact> result = new();
		foreach (Contact contact in _contacts)
		{
			if (contact.DateOfBirth.Month == DateTime.Today.Month
				&& contact.DateOfBirth.Day == DateTime.Today.Day)
			{
				result.Add(contact);
			}
		}

		return result;
	}

	/// <summary>
	/// Находит контакты по подстроке.
	/// </summary>
	/// <param name="contactsList">Список, в котором осуществляется поиск.</param>
	/// <param name="substring">Подстрока, по которой производится поиск.</param>
	/// <returns>Список контактов, содержащих в себе подстроку.</returns>
	public List<Contact> FindContactsBySubstring(List<Contact> contactsList, string substring)
	{
		if (substring == "")
		{
			return contactsList;
		}
		List<Contact> result = new();
		foreach (Contact contact in contactsList)
		{
			if (contact.FullName.Contains(substring))
			{
				result.Add(contact);
			}
		}

		return result;
	}

	/// <summary>
	/// Отсортировать список контактов по полному имени.
	/// </summary>
	/// <param name="contactsList">Список контактов.</param>
	/// <returns>Отсортированный список контактов.</returns>
	public List<Contact> SortContactsByFullName(List<Contact> contactsList)
	{
		var sortedContacts = contactsList.OrderBy(x => x.FullName);
		contactsList = sortedContacts.ToList();
		return contactsList;
	}
}
