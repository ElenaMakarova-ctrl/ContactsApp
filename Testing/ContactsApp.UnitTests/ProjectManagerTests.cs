namespace ContactsApp.UnitTests;

[TestFixture]
internal class ProjectManagerTests
{
	[Test(Description = "Тест сохранения и загрузки списка контактов")]
	public void Test_ProjectManager_SaveLoad()
	{
		// Setup
		var project = new Project();
		var contactToAdd = new Contact
		{
			DateOfBirth = new DateTime(2002, 08, 13),
			Email = "hfjks@mail.ru",
			VKId = "12434",
			PhoneNumber = "+7 (234) 213-43-54",
			FullName = "Test"
		};

		project.AddContact(contactToAdd);
		project.AddContact(contactToAdd);

		// Testing
		var expected = project.Contacts;
		ProjectManager.Save(project);
		var actual = ProjectManager.Load().Contacts;

		// Assert
		CollectionAssert.AreEqual(expected.ToString(), actual.ToString());

		if (File.Exists(ProjectManager.Path))
		{
			File.Delete(ProjectManager.Path);
		}
	}

	[Test(Description ="Тест свойства Path")]
	public void Test_ProjectManager_Path() 
	{
		var expected = @"..\Notes.txt";

		ProjectManager.Path = expected;
		var actual = ProjectManager.Path;

		Assert.AreEqual(expected, actual);
	}
}
