# Исходные данные (п. 3.1 задания)
student_name_ru = "Калмыков Ярослав Владимирович"
student_name_en = "Kalmykov Yaroslav Vladimirovich"
student_number = 8
group_name = "М3О-110БВк-26"
language_name = "Python"
department = 304

control_value = department * student_number
student_id = f"{group_name}/{student_number:02d}"   # :02d — две цифры с ведущим нулём

print(f"Hello to {department} from {student_name_en}, number {student_number}, group {group_name}!")
print(f"Привет, {department}! Это {student_name_ru}, номер {student_number}, группа {group_name}!")
print(f"Student ID: {student_id} | Language: {language_name} | Control: {control_value}")

# «Визитная карточка» Python: количество слов в имени средствами языка
print(f"Words in student_name_en: {len(student_name_en.split())}")
