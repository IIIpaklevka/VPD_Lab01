// interface — «шаблон» данных: описываем, какие поля есть у студента и какого они типа
interface Student {
    // Поле-строка (string): ФИО по-русски
    studentNameRu: string;
    // Поле-строка: ФИО латиницей
    studentNameEn: string;
    // Поле-число (number): номер в списке
    studentNumber: number;
    // Поле-строка: название группы
    groupName: string;
    // Поле-строка: название языка
    languageName: string;
// Конец описания интерфейса
}

// Создаём объект student; запись «: Student» требует, чтобы он точно соответствовал шаблону выше
const student: Student = {
    // Заполняем поле: ФИО по-русски
    studentNameRu: "Калмыков Ярослав Владимирович",
    // Заполняем поле: ФИО латиницей
    studentNameEn: "Kalmykov Yaroslav Vladimirovich",
    // Заполняем поле: номер в списке
    studentNumber: 8,
    // Заполняем поле: группа
    groupName: "М3О-110БВк-26",
    // Заполняем поле: язык
    languageName: "TypeScript",
// Конец объекта
};

// Число с явно указанным типом number: номер кафедры
const department: number = 304;
// Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
const controlValue: number = department * student.studentNumber;
// Собираем student_id: String(...) делает из числа текст, padStart(2, "0") дописывает ноль слева (8 -> "08")
const studentId: string = `${student.groupName}/${String(student.studentNumber).padStart(2, "0")}`;

// console.log печатает в консоль; ${...} внутри обратных кавычек подставляет значения
console.log(`Hello to ${department} from ${student.studentNameEn}, number ${student.studentNumber}, group ${student.groupName}!`);
// То же самое по-русски
console.log(`Привет, ${department}! Это ${student.studentNameRu}, номер ${student.studentNumber}, группа ${student.groupName}!`);
// Строка с student_id, языком и контрольным числом
console.log(`Student ID: ${studentId} | Language: ${student.languageName} | Control: ${controlValue}`);
