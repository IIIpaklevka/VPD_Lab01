fn main() {
    // Исходные данные (п. 3.1 задания) — неизменяемые связывания let
    let student_name_ru = "Калмыков Ярослав Владимирович";
    let student_name_en = "Kalmykov Yaroslav Vladimirovich";
    let student_number = 8;
    let group_name = "М3О-110БВк-26";
    let language_name = "Rust";
    let department = 304;

    let control_value = department * student_number;
    let student_id = format!("{}/{:02}", group_name, student_number);

    println!("Hello to {} from {}, number {}, group {}!", department, student_name_en, student_number, group_name);
    println!("Привет, {}! Это {}, номер {}, группа {}!", department, student_name_ru, student_number, group_name);
    println!("Student ID: {} | Language: {} | Control: {}", student_id, language_name, control_value);

    // «Визитная карточка» Rust: отдельной строкой — сформированный student_id
    println!("student_id = {}", student_id);
}
