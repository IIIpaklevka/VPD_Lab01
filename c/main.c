#include <stdio.h>

#ifdef _WIN32
#include <windows.h>   /* нужен только для переключения консоли Windows в UTF-8 */
#endif

int main(void) {
#ifdef _WIN32
    SetConsoleCP(CP_UTF8);         /* ввод в UTF-8 */
    SetConsoleOutputCP(CP_UTF8);   /* вывод в UTF-8: без этого кириллица превращается в «кракозябры» */
#endif

    /* Исходные данные (п. 3.1 задания) */
    const char *student_name_ru = "Калмыков Ярослав Владимирович";
    const char *student_name_en = "Kalmykov Yaroslav Vladimirovich";
    const int   student_number  = 8;
    const char *group_name      = "М3О-110БВк-26";
    const char *language_name   = "C";
    const int   department      = 304;

    /* Вычисляемое значение */
    const int control_value = department * student_number;

    printf("Hello to %d from %s, number %d, group %s!\n",
           department, student_name_en, student_number, group_name);
    printf("Привет, %d! Это %s, номер %d, группа %s!\n",
           department, student_name_ru, student_number, group_name);
    /* student_id собирается форматированием: %02d дополняет номер нулём до двух цифр */
    printf("Student ID: %s/%02d | Language: %s | Control: %d\n",
           group_name, student_number, language_name, control_value);

    return 0;
}
