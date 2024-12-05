namespace ContactsApp.UnitTests;

[TestFixture]
internal class ProjectTests
{
	[Test(Description = "Тест добавления контакта и получения контакта из списка по индексу")]
	public void Test_Project_IndexAddContact()
	{
		// Setup
		var project = new Project();

		// Testing
		var expected = new Contact();
		project.AddContact(expected);
		var actual = project[0];

		// Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Тест удаления контакта")]
	public void Test_Project_Delete()
	{
		// Setup
		var project = new Project();

		var firstContact = new Contact();
		var secondContact = new Contact();
		var thirdContact = new Contact();

		project.AddContact(firstContact);
		project.AddContact(secondContact);
		project.AddContact(thirdContact);

		project.RemoveContact(firstContact);

		// Testing
		var expected = secondContact;
		var actual = project[0];

		// Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Тест получения индекса контакта в списке контактов")]
	public void Test_Project_IndexOf()
	{
		// Setup
		var project = new Project();
		var firstContact = new Contact();

		// Testing
		var expected = 0;
		
		project.AddContact(firstContact);
		var actual = project.IndexOf(firstContact);

		// Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Тест получения списка именинников")]
	public void Test_Project_FindContactsByBirthDay()
	{
		// Setup
		var project = new Project();

		var firstContact = new Contact();
		firstContact.DateOfBirth = new DateTime(2002, DateTime.Today.Month, DateTime.Today.Day);
		var secondContact = new Contact();
		secondContact.DateOfBirth = new DateTime(2002, DateTime.Today.Month - 1, DateTime.Today.Day);

		project.AddContact(firstContact);
		project.AddContact(secondContact);

		// Testing
		var expected = project.FindContactsByBirthDay();
		var actual = new List<Contact>
		{
			firstContact
		};

		// Assert
		CollectionAssert.AreEqual(expected, actual);
	}

	[Test(Description = "Тест получения списка контактов по подстроке")]
	public void Test_Project_FindContactsBySubstring()
	{
		// Setup
		var project = new Project();

		var firstContact = new Contact();
		firstContact.FullName = "Сеченов Владислав";
		var secondContact = new Contact();
		secondContact.FullName = "Артем Сидоров";

		project.AddContact(firstContact);
		project.AddContact(secondContact);

		// Testing
		var expected = project.FindContactsBySubstring(project.Contacts,"Артем");
		var actual = new List<Contact>
		{
			secondContact
		};

		// Assert
		CollectionAssert.AreEqual(expected, actual);
	}

	[Test(Description = "Тест сортировки списка контактов по полному имени")]
	public void Test_Project_SortContactsByFullName()
	{
		// Setup
		var project = new Project();

		var firstContact = new Contact();
		firstContact.FullName = "Макарова Елена";
		var secondContact = new Contact();
		secondContact.FullName = "Артем Сидоров";

		project.AddContact(firstContact);
		project.AddContact(secondContact);

		// Testing
		var expected = project.SortContactsByFullName(project.Contacts);
		var actual = new List<Contact>
		{
			secondContact,
			firstContact
		};

		// Assert
		CollectionAssert.AreEqual(expected, actual);
	}
}
