# Ниже — исходные данные из пункта 3.1 задания (в Python переменные создаются просто присваиванием)
# Переменная со строкой: ФИО по-русски
student_name_ru = "Калмыков Ярослав Владимирович"
# Переменная со строкой: ФИО латиницей
student_name_en = "Kalmykov Yaroslav Vladimirovich"
# Переменная с целым числом: мой номер в списке группы
student_number = 8
# Переменная со строкой: название группы
group_name = "М3О-110БВк-26"
# Переменная со строкой: название языка
language_name = "Python"
# Переменная с целым числом: номер кафедры
department = 304

# Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
control_value = department * student_number
# f-строка (перед кавычками буква f): то, что в { }, заменяется значением; :02d — минимум 2 цифры с нулём спереди (8 -> 08)
student_id = f"{group_name}/{student_number:02d}"

# print выводит текст на экран; f-строка подставляет значения переменных в { }
print(f"Hello to {department} from {student_name_en}, number {student_number}, group {group_name}!")
# То же самое, но по-русски
print(f"Привет, {department}! Это {student_name_ru}, номер {student_number}, группа {group_name}!")
# Строка с собранным student_id, языком и контрольным числом
print(f"Student ID: {student_id} | Language: {language_name} | Control: {control_value}")

# Особенность Python: считаем слова в имени встроенными средствами
# split() режет строку по пробелам на список слов, len() считает, сколько в списке элементов
print(f"Words in student_name_en: {len(student_name_en.split())}")
