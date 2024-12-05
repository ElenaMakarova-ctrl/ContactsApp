namespace ContactsApp.Model;

/// <summary>
/// Класс для валидации данных.
/// </summary>
public static class ContactValidator
{
	/// <summary>
	/// Проверяет строку по длине.
	/// </summary>
	/// <param name="value">Проверяемое значение.</param>
	/// <param name="objectName">Название проверяемого значения.</param>
	/// <param name="maxLength">Максимальная длина строки.</param>
	/// <exception cref="ArgumentException">Сформированное исключение.</exception>
	public static void CheckLengthOfString(string value, int maxLength, string objectName)
	{
		if(value.Length > maxLength)
		{
			var message = $"{objectName} не может быть больше {maxLength} символов.";
			throw new ArgumentException(message);
		}
	}

	/// <summary>
	/// Проверяет строку на соответствие regex паттерну.
	/// </summary>
	/// <param name="value">Проверяемое значение.</param>
	/// <param name="regexPattern">Regex паттерн.</param>
	/// <param name="objectName">Название переменной.</param>
	/// <exception cref="ArgumentException">Сформированное исключение.</exception>
	public static void CheckValueOnRegexPattern(string value, string regexPattern, string objectName)
	{
		if(!Regex.IsMatch(value, regexPattern))
		{
			var message = $"{objectName} введен неверно.";
			throw new ArgumentException(message);
		}
	}

	/// <summary>
	/// Проверяет меньше ли число введенного минимума.
	/// </summary>
	/// <param name="value">Проверяемое число.</param>
	/// <param name="minValue">Минимальное число.</param>
	/// <param name="objectName">Название переменной.</param>
	/// <exception cref="ArgumentException">Сформированное исключение.</exception>
	public static void CheckMinIntValue(int value, int minValue, string objectName)
	{
		if(value < minValue)
		{
			var message = $"{objectName} не может быть меньше {minValue}";
			throw new ArgumentException(message);
		}
	}

	/// <summary>
	/// Проверяет меньше ли число какого-то минимума.
	/// </summary>
	/// <param name="value">Проверяемое число.</param>
	/// <param name="maxValue">Максимальное число.</param>
	/// <param name="objectName">Название переменной.</param>
	/// <exception cref="ArgumentException"></exception>
	public static void CheckMaxIntValue(int value, int maxValue, string objectName)
	{
		if (value > maxValue)
		{
			var message = $"{objectName} не может быть больше {maxValue}";
			throw new ArgumentException(message);
		}
	}
}
