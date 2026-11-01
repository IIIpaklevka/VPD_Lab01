// Исходные данные (п. 3.1 задания)
const studentNameRu = "Калмыков Ярослав Владимирович";
const studentNameEn = "Kalmykov Yaroslav Vladimirovich";
const studentNumber = 8;
const groupName = "М3О-110БВк-26";
const languageName = "JavaScript";
const department = 304;

const controlValue = department * studentNumber;
const studentId = `${groupName}/${String(studentNumber).padStart(2, "0")}`;

console.log(`Hello to ${department} from ${studentNameEn}, number ${studentNumber}, group ${groupName}!`);
console.log(`Привет, ${department}! Это ${studentNameRu}, номер ${studentNumber}, группа ${groupName}!`);
console.log(`Student ID: ${studentId} | Language: ${languageName} | Control: ${controlValue}`);

// «Визитная карточка» JavaScript: длина строки
console.log(`Length of studentNameEn: ${studentNameEn.length}`);
