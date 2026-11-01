package main

import "fmt"

func main() {
	// Исходные данные (п. 3.1 задания)
	studentNameRu := "Калмыков Ярослав Владимирович"
	studentNameEn := "Kalmykov Yaroslav Vladimirovich"
	studentNumber := 8
	groupName := "М3О-110БВк-26"
	languageName := "Go"
	department := 304

	controlValue := department * studentNumber
	// Вычисляемое значение через короткое объявление :=
	studentID := fmt.Sprintf("%s/%02d", groupName, studentNumber)

	fmt.Printf("Hello to %d from %s, number %d, group %s!\n", department, studentNameEn, studentNumber, groupName)
	fmt.Printf("Привет, %d! Это %s, номер %d, группа %s!\n", department, studentNameRu, studentNumber, groupName)
	fmt.Printf("Student ID: %s | Language: %s | Control: %d\n", studentID, languageName, controlValue)
}
