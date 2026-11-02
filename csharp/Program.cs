// Подключаем пространство имён с кодировками (нужна Encoding.UTF8)
using System.Text;

// Переключаем вывод консоли на UTF-8, чтобы русские буквы отображались правильно
Console.OutputEncoding = Encoding.UTF8;

// Ниже — исходные данные из пункта 3.1 задания; создаём объект типа Student (тип описан внизу файла)
// var — компилятор сам определит тип; new Student(...) создаёт новую запись с данными
var student = new Student(
    // Поле: ФИО по-русски
    StudentNameRu: "Калмыков Ярослав Владимирович",
    // Поле: ФИО латиницей
    StudentNameEn: "Kalmykov Yaroslav Vladimirovich",
    // Поле: номер в списке группы
    StudentNumber: 8,
    // Поле: название группы
    GroupName: "М3О-110БВк-26",
    // Поле: название языка
    LanguageName: "C#");

// const — константа: номер кафедры (значение нельзя менять)
const int department = 304;
// Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
int controlValue = department * student.StudentNumber;
// $"..." — интерполяция: то, что в { }, заменяется значением; :D2 — число минимум из 2 цифр с нулём спереди (8 -> 08)
string studentId = $"{student.GroupName}/{student.StudentNumber:D2}";

// Console.WriteLine печатает строку и переходит на новую; значения в { } подставляются автоматически
Console.WriteLine($"Hello to {department} from {student.StudentNameEn}, number {student.StudentNumber}, group {student.GroupName}!");
// То же самое по-русски
Console.WriteLine($"Привет, {department}! Это {student.StudentNameRu}, номер {student.StudentNumber}, группа {student.GroupName}!");
// Строка с student_id, языком и контрольным числом
Console.WriteLine($"Student ID: {studentId} | Language: {student.LanguageName} | Control: {controlValue}");

// record — короткий способ описать тип-«карточку» с данными: перечисляем поля, а C# сам создаёт всё остальное
record Student(string StudentNameRu, string StudentNameEn, int StudentNumber, string GroupName, string LanguageName);
