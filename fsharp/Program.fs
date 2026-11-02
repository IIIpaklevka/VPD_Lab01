// Открываем пространство имён System (там находится Console)
open System
// Открываем пространство имён System.Text (там находятся кодировки)
open System.Text

// Переключаем вывод консоли на UTF-8 (<- означает «присвоить новое значение»), чтобы русские буквы отображались правильно
Console.OutputEncoding <- Encoding.UTF8

// Ниже — исходные данные из пункта 3.1 задания; let создаёт неизменяемое значение (тип F# определяет сам)
// Строка: ФИО по-русски
let studentNameRu = "Калмыков Ярослав Владимирович"
// Строка: ФИО латиницей
let studentNameEn = "Kalmykov Yaroslav Vladimirovich"
// Целое число: номер в списке группы
let studentNumber = 8
// Строка: название группы
let groupName = "М3О-110БВк-26"
// Строка: название языка
let languageName = "F#"
// Целое число: номер кафедры
let department = 304

// Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
let controlValue = department * studentNumber
// sprintf собирает строку по шаблону: %s — строка, %02d — число минимум из 2 цифр с нулём спереди (8 -> 08)
let studentId = sprintf "%s/%02d" groupName studentNumber

// printfn печатает по шаблону и переводит строку: %d — целое число, %s — строка; значения идут через пробел
printfn "Hello to %d from %s, number %d, group %s!" department studentNameEn studentNumber groupName
// То же самое по-русски
printfn "Привет, %d! Это %s, номер %d, группа %s!" department studentNameRu studentNumber groupName
// Строка с student_id, языком и контрольным числом
printfn "Student ID: %s | Language: %s | Control: %d" studentId languageName controlValue

// Особенность F#: оператор конвейера |> передаёт результат слева на вход следующему шагу справа
// Создаём значение lengths — список длин слов
let lengths =
    // Split(' ') режет английское ФИО по пробелам на массив слов
    studentNameEn.Split(' ')
    // |> передаёт массив слов дальше; Array.map применяет функцию к каждому слову: берём длину слова (fun word -> ... — безымянная функция)
    |> Array.map (fun word -> word.Length)

// Складываем все длины слов вместе — получаем общее число букв
let totalLetters = lengths |> Array.sum
// Печатаем количество слов (длина массива) и общее число букв
printfn "Words: %d, total letters: %d" lengths.Length totalLetters
