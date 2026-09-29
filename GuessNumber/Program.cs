// // Console.Write("Введите число");
// // int numder = int.Parse(Console.ReadLine());
// // if (numder > 0) {
// //     Console.WriteLine("Число положительное");
// // }
// // else if (numder < 0) {
// //     Console.WriteLine("Число отрицательное");
// // }
// // else {
// //     Console.WriteLine("Число равно нулю");
// // }

// // Console.Write("Введите балл (0-100): ");
// // int score = int.Parse(Console.ReadLine());
// // if (score >= 91) {
// //     Console.WriteLine("Оценка: Отлично (5)");
// // }
// // else if (score >= 71) {
// //     Console.WriteLine("Оценка: Хорошо (4)");
// // }
// // else if (score >= 51) {
// //     Console.WriteLine("Оценка: УДОВЛЕТВОРИТЕЛЬНО (3)");
// // }
// // else {
// //     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// // }
// // Console.Write("Введите количество посящений (из 19): ");
// // int attendance = int.Parse(Console.ReadLine());
// // Console.Write("Введите средний балл по практике: ");
// // double practiceGra = double.Parse(Console.ReadLine());
// // bool goodAttendance = attendance >= 14;
// // bool goodGrades = practiceGra >= 3.0;
// // if (goodAttendance && goodGrades) {
// //     Console.WriteLine("+ Допуск к экзамену развершен.");
// // }
// // else if (!goodAttendance && goodGrades) {
// //     Console.WriteLine("- Недостаточно посящений. Нужно отработать пропуски.");
// // }
// // else if (!goodAttendance && !goodGrades) {
// //     Console.WriteLine("- Низкий балл по практите. Нужно пересдать работы.");
// // }
// // else {
// //     Console.WriteLine("- Проблемы и с посящением и с оценками мРОЧНО К ПРЕПОДУ ");
// // }
// using System.Diagnostics;

// Console.Write("Введите возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном: (°C)");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "четное" : "нечетное";
// Console.WriteLine($"Число {n} - {parity}");
// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.WriteLine("Выберете пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-243121212");
//         break;
//     case "2":
//         Console.WriteLine("ktktktktkt");
//         break;
//     case "3":
//         Console.WriteLine("лелелелеле");
//         break;
//     case "4":
//         Console.WriteLine("пупупупупупупупупупуупупуппууппупуп");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }
Console.Write("Введите номер месяца (1–12): ");
int monthNumber = int.Parse(Console.ReadLine());

switch (monthNumber)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Зима");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Весна");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Лето");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Ошибка: в году всего 12 месяцев!");
        break;
}