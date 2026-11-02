#!/usr/bin/env bash
# Первая строка (shebang) говорит системе: запускать этот скрипт программой bash
# Ниже — исходные данные из пункта 3.1 задания; в Bash переменная создаётся записью имя=значение (пробелов вокруг = быть не должно)
# Переменная: ФИО по-русски
student_name_ru="Калмыков Ярослав Владимирович"
# Переменная: ФИО латиницей
student_name_en="Kalmykov Yaroslav Vladimirovich"
# Переменная: номер в списке группы
student_number=8
# Переменная: название группы
group_name="М3О-110БВк-26"
# Переменная: название языка
language_name="Bash"
# Переменная: номер кафедры
department=304

# $(( ... )) — арифметика в Bash; считаем кафедра * номер в списке (304 * 8 = 2432)
control_value=$((department * student_number))
# $(...) — подстановка команды: запускаем printf и записываем его результат в переменную; %02d — число минимум из 2 цифр с нулём спереди (8 -> 08)
student_id=$(printf "%s/%02d" "$group_name" "$student_number")

# echo печатает текст; $имя заменяется значением переменной
echo "Hello to $department from $student_name_en, number $student_number, group $group_name!"
# То же самое по-русски
echo "Привет, $department! Это $student_name_ru, номер $student_number, группа $group_name!"
# Строка с student_id, языком и контрольным числом
echo "Student ID: $student_id | Language: $language_name | Control: $control_value"

# Особенность Bash: настоящий конвейер (pipe) | — вывод одной команды передаётся на вход другой
# Комментарий к следующим двум строкам: tr -d ' ' убирает пробелы, которые утилита wc печатает перед числом на macOS
# printf печатает имя, | передаёт его в wc -w (считает слова), tr -d ' ' убирает лишние пробелы; результат — в переменную words
words=$(printf '%s' "$student_name_en" | wc -w | tr -d ' ')
# То же, но wc -m считает символы (буквы и пробелы); результат — в переменную chars
chars=$(printf '%s' "$student_name_en" | wc -m | tr -d ' ')
# Печатаем количество слов и символов
echo "Words: $words, characters: $chars"
