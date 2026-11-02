// Подключаем класс PrintStream — «поток вывода», через него будем печатать текст
import java.io.PrintStream;
// Подключаем набор стандартных кодировок (нужна UTF-8)
import java.nio.charset.StandardCharsets;

// В Java весь код живёт внутри классов; имя класса Main должно совпадать с именем файла Main.java
public class Main {
    // main — точка входа: именно этот метод запускается первым (static — вызывается без создания объекта, void — ничего не возвращает)
    public static void main(String[] args) {
        // Создаём поток вывода поверх обычного экрана и явно указываем UTF-8, чтобы русские буквы не зависели от настроек консоли
        PrintStream out = new PrintStream(System.out, true, StandardCharsets.UTF_8);

        // Ниже — исходные данные из пункта 3.1 задания; в Java тип каждой переменной пишется явно
        // String — тип «строка»: ФИО по-русски
        String studentNameRu = "Калмыков Ярослав Владимирович";
        // String: ФИО латиницей
        String studentNameEn = "Kalmykov Yaroslav Vladimirovich";
        // int — тип «целое число»: номер в списке группы
        int studentNumber = 8;
        // String: название группы
        String groupName = "М3О-110БВк-26";
        // String: название языка
        String languageName = "Java";
        // int: номер кафедры
        int department = 304;

        // Контрольное значение: кафедра * номер в списке (304 * 8 = 2432)
        int controlValue = department * studentNumber;
        // String.format собирает строку по шаблону: %s — строка, %02d — число минимум из 2 цифр с нулём спереди (8 -> 08)
        String studentId = String.format("%s/%02d", groupName, studentNumber);

        // printf печатает по шаблону: %d — целое число, %s — строка, %n — переход на новую строку
        out.printf("Hello to %d from %s, number %d, group %s!%n", department, studentNameEn, studentNumber, groupName);
        // То же самое по-русски
        out.printf("Привет, %d! Это %s, номер %d, группа %s!%n", department, studentNameRu, studentNumber, groupName);
        // Строка с student_id, языком и контрольным числом
        out.printf("Student ID: %s | Language: %s | Control: %d%n", studentId, languageName, controlValue);
    // Закрывающая скобка — конец метода main
    }
// Закрывающая скобка — конец класса Main
}
