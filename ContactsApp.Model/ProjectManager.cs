namespace ContactsApp.Model;

/// <summary>
/// Менеджер проекта.
/// </summary>
static public class ProjectManager
{
	/// <summary>
	/// Путь к каталогу AppData.
	/// </summary>
	private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	/// <summary>
	/// Путь к каталогу для сохранения контакта.
	/// </summary>
    private static string _folderPath = $"{_appDataPath}\\MakarovaEA\\ContactsApp";

    /// <summary>
    /// Название файла.
    /// </summary>
    private static string _fileName = "Contacts.txt";

	/// <summary>
	/// Полный путь к файлу.
	/// </summary>
	private static string _filePath = $"{_folderPath}\\{_fileName}";

	/// <summary>
	/// Заданный пользователем путь для сохранения и загрузки.
	/// </summary>
	private static string _path = _filePath;

	/// <summary>
	/// Возвращает или задает путь для сохранения или загрузки.
	/// </summary>
	public static string Path
	{
		get { return _path; }
		set { _path = value; }
	}

	/// <summary>
	/// Сохранить список контактов.
	/// </summary>
	/// <param name="project">Список контактов для сохранения.</param>
	public static void Save(Project project)
	{
		JsonSerializer serializer = new();

		if (!Directory.Exists(_folderPath))
		{
			Directory.CreateDirectory(_folderPath);
		}

		using (StreamWriter sw = new(_path))
		using (JsonWriter writer = new JsonTextWriter(sw))
		{
			serializer.Serialize(writer, project);
		}
	}

	/// <summary>
	/// Загрузить список контактов.
	/// </summary>
	/// <returns>Загруженный список контактов.</returns>
	public static Project Load()
	{
		Project project = new();
		JsonSerializer serializer = new();

		using (StreamReader sr = new(_path))
		using (JsonReader reader = new JsonTextReader(sr))
		{
			project = serializer.Deserialize<Project>(reader);
		}

		return project ?? new Project();
	}
}
