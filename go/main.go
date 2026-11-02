// Каждый файл в Go принадлежит пакету; пакет main — это запускаемая программа (а не библиотека)
package main

// Подключаем стандартный пакет fmt (от «format»): он умеет печатать и форматировать текст
import "fmt"

// func объявляет функцию; main — главная функция, с неё начинается выполнение программы
func main() {
	// Ниже — исходные данные из пункта 3.1 задания; := создаёт переменную, и Go сам определяет её тип
	// Строка: ФИО по-русски
	studentNameRu := "Калмыков Ярослав Владимирович"
	// Строка: ФИО латиницей
	studentNameEn := "Kalmykov Yaroslav Vladimirovich"
	// Целое число: номер в списке группы
	studentNumber := 8
	// Строка: название группы
	groupName := "М3О-110БВк-26"
	// Строка: название языка
	languageName := "Go"
	// Целое число: номер кафедры
	department := 304

	// Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
	controlValue := department * studentNumber
	// Sprintf собирает строку по шаблону (но не печатает): %s — строка, %02d — число минимум из 2 цифр с нулём спереди (8 -> 08)
	studentID := fmt.Sprintf("%s/%02d", groupName, studentNumber)

	// Printf печатает по шаблону: %d — целое число, %s — строка, \n — новая строка
	fmt.Printf("Hello to %d from %s, number %d, group %s!\n", department, studentNameEn, studentNumber, groupName)
	// То же самое по-русски
	fmt.Printf("Привет, %d! Это %s, номер %d, группа %s!\n", department, studentNameRu, studentNumber, groupName)
	// Строка с собранным student_id, языком и контрольным числом
	fmt.Printf("Student ID: %s | Language: %s | Control: %d\n", studentID, languageName, controlValue)
// Закрывающая скобка — конец функции main
}
