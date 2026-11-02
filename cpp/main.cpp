// Подключаем библиотеку ввода-вывода: даёт std::cout (вывод на экран)
#include <iostream>
// Подключаем библиотеку форматирования вывода: даёт std::setw и std::setfill
#include <iomanip>
// Подключаем библиотеку для работы со строками: даёт тип std::string
#include <string>

// Проверка при сборке: если компилируем под Windows...
#ifdef _WIN32
// ...подключаем системную библиотеку Windows, чтобы настроить кодировку консоли
#include <windows.h>
// Конец блока только для Windows
#endif

// main — главная функция, с неё начинается выполнение программы
int main() {
// Этот кусок кода будет собран только под Windows
#ifdef _WIN32
    // Ввод в консоли — в кодировке UTF-8
    SetConsoleCP(CP_UTF8);
    // Вывод в консоли — тоже в UTF-8, чтобы корректно отображалась кириллица
    SetConsoleOutputCP(CP_UTF8);
// Конец блока только для Windows
#endif

    // Ниже — исходные данные из пункта 3.1 задания
    // Строка (std::string) с ФИО по-русски; const — менять нельзя
    const std::string student_name_ru = "Калмыков Ярослав Владимирович";
    // Строка с ФИО латиницей
    const std::string student_name_en = "Kalmykov Yaroslav Vladimirovich";
    // Целое число — мой номер в списке группы
    const int         student_number  = 8;
    // Строка с названием группы
    const std::string group_name      = "М3О-110БВк-26";
    // Строка с названием языка
    const std::string language_name   = "C++";
    // Целое число — номер кафедры
    const int         department      = 304;

    // Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
    const int control_value = department * student_number;

    // std::cout — «поток вывода» на экран; оператор << «передаёт» в него данные по цепочке
    std::cout << "Hello to " << department << " from " << student_name_en
              // Продолжаем цепочку: выводим текст, номер в списке, текст, название группы
              << ", number " << student_number << ", group " << group_name << "!\n";
    // Вторая строка вывода по-русски; \n — переход на новую строку
    std::cout << "Привет, " << department << "! Это " << student_name_ru
              // Продолжение цепочки: номер в списке и группа
              << ", номер " << student_number << ", группа " << group_name << "!\n";

    // setw(2) задаёт ширину поля 2 символа, setfill('0') заполняет пустое место нулями: 8 -> 08
    std::cout << "Student ID: " << group_name << "/"
              // Выводим номер в списке с шириной 2 и заполнением нулями
              << std::setw(2) << std::setfill('0') << student_number
              // Выводим название языка
              << " | Language: " << language_name
              // Выводим контрольное число и переход на новую строку
              << " | Control: " << control_value << "\n";

    // Возвращаем 0 — «программа завершилась успешно»
    return 0;
// Закрывающая скобка — конец функции main
}
