:- encoding(utf8).

% Исходные данные (п. 3.1 задания) — факт student/5
student('Калмыков Ярослав Владимирович', 'Kalmykov Yaroslav Vladimirovich', 8,
        'М3О-110БВк-26', 'Prolog').

department(304).

% Правило: контрольное значение вычисляется из факта student/5
control_value(V) :-
    student(_, _, N, _, _),
    department(D),
    V is D * N.

% Правило: идентификатор student_id = группа/номер (минимум две цифры)
student_id(Id) :-
    student(_, _, N, Group, _),
    format(atom(Num), '~`0t~d~2|', [N]),
    atomic_list_concat([Group, '/', Num], Id).

main :-
    student(NameRu, NameEn, N, Group, Lang),
    department(D),
    control_value(V),                   % запрос к правилу
    student_id(Id),
    format("Hello to ~d from ~w, number ~d, group ~w!~n", [D, NameEn, N, Group]),
    format("Привет, ~d! Это ~w, номер ~d, группа ~w!~n", [D, NameRu, N, Group]),
    format("Student ID: ~w | Language: ~w | Control: ~d~n", [Id, Lang, V]).
