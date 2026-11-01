# Changelog

Все заметные изменения проекта описываются в этом файле.

## [1.0.0] - 2026-11-01

Первая законченная версия лабораторной работы № 1 («Введение в профессиональную деятельность»).

### Added
- Реализации общего вывода (п. 3.2 задания) на 13 языках: C, C++, Python, JavaScript, TypeScript, Java, C#, F#, Go, Rust, Bash, Prolog, Assembler (AArch64, Apple Clang).
- «Визитная карточка» каждого языка: `printf` и `%02d` (C), `setw`/`setfill` (C++), f-строки (Python), template literals (JavaScript, TypeScript), `interface` (TypeScript), `javap -c` (Java), интерполяция и `record` (C#), оператор `|>` (F#), `:=` (Go), `let`/`format!` (Rust), `pipe` и `$(...)` (Bash), факт и правило (Prolog).
- Корректный вывод кириллицы в C/C++ на Windows (`SetConsoleOutputCP(CP_UTF8)`).
- `README.md` с таблицей «язык — версия инструмента — команда сборки/запуска».
- `.gitignore` для артефактов сборки.

### Git
- Реализация Bash выполнена в ветке `feature/bash` и слита в `main`.
- Разрешён намеренный merge-конфликт в `README.md` (строка `Status`).
- Версия отмечена аннотированным тегом `v1.0.0`.
