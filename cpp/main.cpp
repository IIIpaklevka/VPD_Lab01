#include <iostream>
#include <iomanip>
#include <string>

#ifdef _WIN32
#include <windows.h>   // только для переключения консоли Windows в UTF-8
#endif

int main() {
#ifdef _WIN32
    SetConsoleCP(CP_UTF8);
    SetConsoleOutputCP(CP_UTF8);
#endif

    // Исходные данные (п. 3.1 задания)
    const std::string student_name_ru = "Калмыков Ярослав Владимирович";
    const std::string student_name_en = "Kalmykov Yaroslav Vladimirovich";
    const int         student_number  = 8;
    const std::string group_name      = "М3О-110БВк-26";
    const std::string language_name   = "C++";
    const int         department      = 304;

    const int control_value = department * student_number;

    std::cout << "Hello to " << department << " from " << student_name_en
              << ", number " << student_number << ", group " << group_name << "!\n";
    std::cout << "Привет, " << department << "! Это " << student_name_ru
              << ", номер " << student_number << ", группа " << group_name << "!\n";

    // setw(2) + setfill('0') дают двузначный номер: 8 -> 08
    std::cout << "Student ID: " << group_name << "/"
              << std::setw(2) << std::setfill('0') << student_number
              << " | Language: " << language_name
              << " | Control: " << control_value << "\n";

    return 0;
}
