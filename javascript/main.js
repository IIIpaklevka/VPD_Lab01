// Ниже — исходные данные из пункта 3.1 задания; const создаёт переменную, которую нельзя переприсвоить
// Строка: ФИО по-русски
const studentNameRu = "Калмыков Ярослав Владимирович";
// Строка: ФИО латиницей
const studentNameEn = "Kalmykov Yaroslav Vladimirovich";
// Число: мой номер в списке группы
const studentNumber = 8;
// Строка: название группы
const groupName = "М3О-110БВк-26";
// Строка: название языка
const languageName = "JavaScript";
// Число: номер кафедры
const department = 304;

// Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
const controlValue = department * studentNumber;
// String(...) превращает число в текст, padStart(2, "0") дополняет его слева нулями до длины 2 (8 -> "08"); `...${}...` — шаблонная строка
const studentId = `${groupName}/${String(studentNumber).padStart(2, "0")}`;

// console.log выводит текст в консоль; в обратных кавычках ${...} заменяется значением переменной
console.log(`Hello to ${department} from ${studentNameEn}, number ${studentNumber}, group ${groupName}!`);
// То же самое по-русски
console.log(`Привет, ${department}! Это ${studentNameRu}, номер ${studentNumber}, группа ${groupName}!`);
// Строка с student_id, языком и контрольным числом
console.log(`Student ID: ${studentId} | Language: ${languageName} | Control: ${controlValue}`);

// Особенность JavaScript: у строки есть свойство length — количество символов в ней
console.log(`Length of studentNameEn: ${studentNameEn.length}`);
