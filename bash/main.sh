#!/usr/bin/env bash
# Исходные данные (п. 3.1 задания) — shell-переменные
student_name_ru="Калмыков Ярослав Владимирович"
student_name_en="Kalmykov Yaroslav Vladimirovich"
student_number=8
group_name="М3О-110БВк-26"
language_name="Bash"
department=304

control_value=$((department * student_number))
student_id=$(printf "%s/%02d" "$group_name" "$student_number")

echo "Hello to $department from $student_name_en, number $student_number, group $group_name!"
echo "Привет, $department! Это $student_name_ru, номер $student_number, группа $group_name!"
echo "Student ID: $student_id | Language: $language_name | Control: $control_value"

# «Визитная карточка» Bash: настоящий pipe | и command substitution $(...)
# tr -d ' ' убирает пробелы, которые wc печатает перед числом на macOS
words=$(printf '%s' "$student_name_en" | wc -w | tr -d ' ')
chars=$(printf '%s' "$student_name_en" | wc -m | tr -d ' ')
echo "Words: $words, characters: $chars"
