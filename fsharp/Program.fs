open System
open System.Text

Console.OutputEncoding <- Encoding.UTF8

// Исходные данные (п. 3.1 задания) — неизменяемые связывания
let studentNameRu = "Калмыков Ярослав Владимирович"
let studentNameEn = "Kalmykov Yaroslav Vladimirovich"
let studentNumber = 8
let groupName = "М3О-110БВк-26"
let languageName = "F#"
let department = 304

let controlValue = department * studentNumber
let studentId = sprintf "%s/%02d" groupName studentNumber

printfn "Hello to %d from %s, number %d, group %s!" department studentNameEn studentNumber groupName
printfn "Привет, %d! Это %s, номер %d, группа %s!" department studentNameRu studentNumber groupName
printfn "Student ID: %s | Language: %s | Control: %d" studentId languageName controlValue

// «Визитная карточка» F#: оператор конвейера |>
let lengths =
    studentNameEn.Split(' ')
    |> Array.map (fun word -> word.Length)

let totalLetters = lengths |> Array.sum
printfn "Words: %d, total letters: %d" lengths.Length totalLetters
