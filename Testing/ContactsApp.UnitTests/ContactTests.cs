namespace ContactsApp.UnitTests;

[TestFixture]
public class ContactTests
{
	[Test(Description = "Позитивный тест геттера и сеттера FullName")]
	public void Test_FullName_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "Сеченов Владислав";
		contact.FullName = expected;
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Негативный тест геттера и сеттера FullName (длина имени больше 100)")]
	public void Test_FullName_FalseValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongFullName = "Сеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов ВладиславСеченов Владислав";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.FullName = wrongFullName,
			"Должно возникать исключение, если полное имя длиннее 100 символов");
	}

	[Test(Description = "Тест геттера и сеттера FullName (каждое слово начинается с заглавной буквы)")]
	public void Test_FullName_TitleCase()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "Сеченов Владислав";
		contact.FullName = "сеченов владислав";
		var actual = contact.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Позитивный тест геттера и сеттера Email")]
	public void Test_Email_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "hjasfd@mail.ru";
		contact.Email = expected;
		var actual = contact.Email;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Негативный тест геттера и сеттера Email (длина email больше 100)")]
	public void Test_Email_FalseValue_EmailLength()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongEmail = "hjdfdsbhdvhsbhjacsbhjacsbasbhabcshbascbhjacsbhjasbchabschbascbacsbhjacsbhjascbhjaschaschvjacsvhjavscavschvacsvhjacshjavschvacsvhascvhjasvchacsjvacvajcvjhacjhacsvhjv@mail.ru";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.Email = wrongEmail,
			"Должно возникать исключение, если email длиннее 100 символов");
	}

	[Test(Description = "Негативный тест геттера и сеттера Email (email должен соответствовать Regex паттерну)")]
	public void Test_Email_FalseValue_RegexPattern()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var wrongEmail = "jskdfhk";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.Email = wrongEmail,
			"Должно возникать исключение, если email не соотвествует Regex паттерну");
	}

	[Test(Description = "Позитивный тест геттера и сеттера PhoneNumber")]
	public void Test_PhoneNumber_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var firstExpected = "+7 (345) 234-45-65";
		contact.PhoneNumber = firstExpected;
		var firstActual = contact.PhoneNumber;

		var secondExpected = "+79261234567";
		contact.PhoneNumber = secondExpected;
		var secondActual = contact.PhoneNumber;

		var thirdExpected = "89261234567";
		contact.PhoneNumber = thirdExpected;
		var thirdActual = contact.PhoneNumber;

		//Assert
		Assert.AreEqual(firstExpected, firstActual);
		Assert.AreEqual(secondExpected, secondActual);
		Assert.AreEqual(thirdExpected, thirdActual);
	}

	[Test(Description = "Негативный тест геттера и сеттера PhoneNumber")]
	public void Test_PhoneNumber_FalseValue()
	{
		//Setup
		Contact contact = new Contact();

		var firstWrongPhoneNumber = "98643";
		var secondWrongPhoneNumber = "75823";
		var thirdWrongPhoneNumber = "+74321";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.PhoneNumber = firstWrongPhoneNumber,
			"Должно возникать исключение, если номер телефона не соотвествует Regex паттерну");
		Assert.Throws<ArgumentException>(() => contact.PhoneNumber = secondWrongPhoneNumber,
			"Должно возникать исключение, если номер телефона не соотвествует Regex паттерну");
		Assert.Throws<ArgumentException>(() => contact.PhoneNumber = thirdWrongPhoneNumber,
			"Должно возникать исключение, если номер телефона не соотвествует Regex паттерну");
	}

	[Test(Description = "Позитивный тест геттера и сеттера DateOfBirth")]
	public void Test_DateOfBirth_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = new DateTime(2002,08,23);
		contact.DateOfBirth = expected;
		var actual = contact.DateOfBirth;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Негативный тест геттера и сеттера DateOfBirth (год рождения меньше 1900)")]
	public void Test_DateOfBirth_FalseValue_MinValue()
	{
		//Setup
		Contact contact = new Contact();

		var wrongDateOfBirth = new DateTime(1899, 10, 12);

		//Assert
		Assert.Throws<ArgumentException>(() => contact.DateOfBirth = wrongDateOfBirth,
			"Должно возникать исключение, если номер телефона не соотвествует Regex паттерну");
	}

	[Test(Description = "Негативный тест геттера и сеттера DateOfBirth (год рождения больше текущего года)")]
	public void Test_DateOfBirth_FalseValue_MaxValue()
	{
		//Setup
		Contact contact = new Contact();

		var wrongDateOfBirth = new DateTime(DateTime.Today.Year + 1, 1, 3);

		//Assert
		Assert.Throws<ArgumentException>(() => contact.DateOfBirth = wrongDateOfBirth,
			"Должно возникать исключение, если номер телефона не соотвествует Regex паттерну");
	}

	[Test(Description = "Позитивный тест геттера и сеттера VKId")]
	public void Test_VKId_CorrectValue()
	{
		//Setup
		Contact contact = new Contact();

		//Testing
		var expected = "12423552";
		contact.VKId = expected;
		var actual = contact.VKId;

		//Assert
		Assert.AreEqual(expected, actual);
	}

	[Test(Description = "Негативный тест геттера и сеттера VKId (длина VKId больше 100)")]
	public void Test_VKId_FalseValue()
	{
		//Setup
		Contact contact = new Contact();

		var wrongVKId = "hjdfdsbhdvhsbhjacsbhjacsbasbhabcshbascbhjacsbhjasbchabschbascbacsbhjacsbhjascbhjaschasc1234612412";

		//Assert
		Assert.Throws<ArgumentException>(() => contact.VKId = wrongVKId,
			"Должно возникать исключение, если VKId длиннее 50 символов");
	}
}