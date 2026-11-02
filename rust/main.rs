// fn объявляет функцию; main — главная функция, с неё начинается выполнение программы
fn main() {
    // Ниже — исходные данные из пункта 3.1 задания; let создаёт переменную, которую по умолчанию нельзя изменить
    // Строка: ФИО по-русски
    let student_name_ru = "Калмыков Ярослав Владимирович";
    // Строка: ФИО латиницей
    let student_name_en = "Kalmykov Yaroslav Vladimirovich";
    // Целое число: номер в списке группы
    let student_number = 8;
    // Строка: название группы
    let group_name = "М3О-110БВк-26";
    // Строка: название языка
    let language_name = "Rust";
    // Целое число: номер кафедры
    let department = 304;

    // Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
    let control_value = department * student_number;
    // format! собирает строку по шаблону: {} — сюда подставится значение, {:02} — число минимум из 2 цифр с нулём спереди (8 -> 08)
    let student_id = format!("{}/{:02}", group_name, student_number);

    // println! печатает строку и переводит строку; каждое {} заменяется очередным значением из списка справа (знак ! значит, что это макрос)
    println!("Hello to {} from {}, number {}, group {}!", department, student_name_en, student_number, group_name);
    // То же самое по-русски
    println!("Привет, {}! Это {}, номер {}, группа {}!", department, student_name_ru, student_number, group_name);
    // Строка с student_id, языком и контрольным числом
    println!("Student ID: {} | Language: {} | Control: {}", student_id, language_name, control_value);

    // Особенность Rust: выводим отдельной строкой собранный student_id
    println!("student_id = {}", student_id);
// Закрывающая скобка — конец функции main
}
