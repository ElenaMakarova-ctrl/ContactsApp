ContactApp - приложение, разрабатываемое в рамках учебного курса "Технологии разработки ПО"

Пользовательское приложение ContactsApp, предназначено для ведения и хранения контактов. 
Приложение должно:
1) Обеспечивать стабильную работу приложения при порядке 200 контактов;
2) Обеспечивать поиск, навигацию по созданным контактам по фамилии и имени;
3) Предоставить инструменты для просмотра и редактирования контактов;
4) Сохранять и восстанавливать контакты между сессиями приложения;
5) Выполнять промежуточные сохранения контактов на машине пользователя на случай аварийного завершения программы, отключения компьютера и т.д. – для защиты от потери данных.

	Для создания приложения использовался следующий стек технологий:

•	C# является языком программирования для создания всего проекта;

•	Windows Forms используется для создания пользовательского интерфейса приложения;

•	Платформа .NET 6.0

•	Newtonsoft.Json 13.0.3 используется для сериализации контактов в формат JSON и десериализации из этого формата для сохранения в файл и загрузки из файла;

•	NUnit 3.13.3 используется для автоматического юнит-тестирования классов. 
