# VPD Lab 01: языки программирования, терминал и Git

- **Студент:** Калмыков Ярослав Владимирович
- **Группа:** М3О-110БВк-26
- **Номер в списке группы:** 8

Status: implementations done, ready for review

## Цель проекта

Один и тот же результат (приветствие, идентификатор `student_id` и контрольное значение `control_value = 304 × 8 = 2432`) получен на 13 языках программирования с разными моделями выполнения: компиляция в машинный код, байт-код, интерпретация, транспиляция. Проект ведётся в Git: ветки, слияния, конфликт, тег.

## Используемые языки

1. C
2. C++
3. Python
4. JavaScript
5. TypeScript
6. Java
7. C#
8. F#
9. Go
10. Rust
11. Bash
12. Prolog
13. Assembler (AArch64, Apple Clang)

## Инструменты и команды

Все команды выполняются из каталога соответствующего языка во встроенном терминале VS Code (macOS, zsh). Версии получены командами из столбца «Версия».

| Язык | Версия инструмента | Команда сборки/запуска |
|------|--------------------|------------------------|
| C | `<gcc --version>` | `gcc -Wall -Wextra -pedantic main.c -o main` и `./main` (на macOS `gcc` — это Apple Clang) |
| C++ | `<g++ --version>` | `g++ -Wall -Wextra -pedantic main.cpp -o main` и `./main` |
| Python | `<python3 --version>` | `python3 main.py` |
| JavaScript | `<node --version>` | `node main.js` |
| TypeScript | `<tsc --version>` | `tsc` и `node dist/main.js` (настройки в `tsconfig.json`) |
| Java | `<javac -version>` | `javac -encoding UTF-8 Main.java` и `java Main` |
| C# | `<dotnet --version>` | `dotnet run` |
| F# | `<dotnet --version>` | `dotnet run` |
| Go | `<go version>` | `go run main.go` |
| Rust | `<rustc --version>` | `rustc main.rs -o main` и `./main` |
| Bash | `<bash --version>` | `bash main.sh` |
| Prolog | `<swipl --version>` | `swipl -q -s main.pl -g main -t halt` |
| Assembler | `<as --version>` | `clang -c assembler.s -o assembler.o`, `clang assembler.o -o assembler`, `./assembler` |

## Пример ожидаемого вывода

Для каждого языка (кроме assembler) выводятся три строки; в `Language` подставляется имя языка:

```text
Hello to 304 from Kalmykov Yaroslav Vladimirovich, number 8, group М3О-110БВк-26!
Привет, 304! Это Калмыков Ярослав Владимирович, номер 8, группа М3О-110БВк-26!
Student ID: М3О-110БВк-26/08 | Language: C | Control: 2432
```

Assembler выводит только первую (английскую) строку. Некоторые языки добавляют ещё одну строку «визитной карточки» (например, количество слов в имени в Python).

## Кириллица в C/C++

Исходные файлы сохранены в UTF-8, поэтому русские строки лежат в программе в виде байтов UTF-8. Консоль Windows по умолчанию использует другую кодовую страницу, поэтому в начале `main()` под условием `#ifdef _WIN32` вызываются `SetConsoleCP(CP_UTF8)` и `SetConsoleOutputCP(CP_UTF8)` из `<windows.h>` (на Windows альтернатива — `chcp 65001`). На macOS (где выполнялась работа) терминал уже работает в UTF-8 (проверка: `echo $LANG` выводит что-то вроде `ru_RU.UTF-8` или `en_US.UTF-8`), поэтому блок `#ifdef _WIN32` не компилируется, а русский текст выводится корректно без дополнительных настроек.

## Assembler

- **ОС:** macOS (Apple Silicon)
- **Архитектура процессора:** arm64 (проверено командой `uname -m`)
- **Язык ассемблера:** AArch64
- **Toolchain:** нативный Apple Clang (Command Line Tools)
- **Сборка и запуск:**

```text
clang -c assembler.s -o assembler.o
clang assembler.o -o assembler
./assembler
```

Программа выводит одну английскую строку приветствия через функцию `puts`.

## Структура проекта

```text
VPD_Lab01/
├── README.md
├── CHANGELOG.md
├── .gitignore
├── c/  cpp/  python/  javascript/  typescript/
├── java/  csharp/  fsharp/  go/  rust/
└── bash/  prolog/  asm/
```
