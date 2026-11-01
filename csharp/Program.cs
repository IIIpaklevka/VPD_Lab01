using System.Text;

Console.OutputEncoding = Encoding.UTF8;   // UTF-8 вывод в консоль

// Исходные данные (п. 3.1 задания) — типизированная запись (record)
var student = new Student(
    StudentNameRu: "Калмыков Ярослав Владимирович",
    StudentNameEn: "Kalmykov Yaroslav Vladimirovich",
    StudentNumber: 8,
    GroupName: "М3О-110БВк-26",
    LanguageName: "C#");

const int department = 304;
int controlValue = department * student.StudentNumber;
string studentId = $"{student.GroupName}/{student.StudentNumber:D2}";   // D2 — две цифры

Console.WriteLine($"Hello to {department} from {student.StudentNameEn}, number {student.StudentNumber}, group {student.GroupName}!");
Console.WriteLine($"Привет, {department}! Это {student.StudentNameRu}, номер {student.StudentNumber}, группа {student.GroupName}!");
Console.WriteLine($"Student ID: {studentId} | Language: {student.LanguageName} | Control: {controlValue}");

record Student(string StudentNameRu, string StudentNameEn, int StudentNumber, string GroupName, string LanguageName);
