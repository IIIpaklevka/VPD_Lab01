import java.io.PrintStream;
import java.nio.charset.StandardCharsets;

public class Main {
    public static void main(String[] args) {
        // Явный UTF-8 вывод: не зависит от кодировки консоли по умолчанию
        PrintStream out = new PrintStream(System.out, true, StandardCharsets.UTF_8);

        // Исходные данные (п. 3.1 задания) — типизированные переменные
        String studentNameRu = "Калмыков Ярослав Владимирович";
        String studentNameEn = "Kalmykov Yaroslav Vladimirovich";
        int studentNumber = 8;
        String groupName = "М3О-110БВк-26";
        String languageName = "Java";
        int department = 304;

        int controlValue = department * studentNumber;
        String studentId = String.format("%s/%02d", groupName, studentNumber);

        out.printf("Hello to %d from %s, number %d, group %s!%n", department, studentNameEn, studentNumber, groupName);
        out.printf("Привет, %d! Это %s, номер %d, группа %s!%n", department, studentNameRu, studentNumber, groupName);
        out.printf("Student ID: %s | Language: %s | Control: %d%n", studentId, languageName, controlValue);
    }
}
