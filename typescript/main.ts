// Описание данных студента через interface с явными типами полей
interface Student {
    studentNameRu: string;
    studentNameEn: string;
    studentNumber: number;
    groupName: string;
    languageName: string;
}

const student: Student = {
    studentNameRu: "Калмыков Ярослав Владимирович",
    studentNameEn: "Kalmykov Yaroslav Vladimirovich",
    studentNumber: 8,
    groupName: "М3О-110БВк-26",
    languageName: "TypeScript",
};

const department: number = 304;
const controlValue: number = department * student.studentNumber;
const studentId: string = `${student.groupName}/${String(student.studentNumber).padStart(2, "0")}`;

console.log(`Hello to ${department} from ${student.studentNameEn}, number ${student.studentNumber}, group ${student.groupName}!`);
console.log(`Привет, ${department}! Это ${student.studentNameRu}, номер ${student.studentNumber}, группа ${student.groupName}!`);
console.log(`Student ID: ${studentId} | Language: ${student.languageName} | Control: ${controlValue}`);
