Console.Write("Введите число");
int numder = int.Parse(Console.ReadLine());
if (numder > 0) {
    Console.WriteLine("Число положительное");
}
else if (numder < 0) {
    Console.WriteLine("Число отрицательное");
}
else {
    Console.WriteLine("Число равно нулю");
}

Console.Write("Введите балл (0-100): ");
int score = int.Parse(Console.ReadLine());
if (score >= 91) {
    Console.WriteLine("Оценка: Отлично (5)");
}
else if (score >= 71) {
    Console.WriteLine("Оценка: Хорошо (4)");
}
else if (score >= 51) {
    Console.WriteLine("Оценка: УДОВЛЕТВОРИТЕЛЬНО (3)");
}
else {
    Console.WriteLine("Оценка: Неудовлетворительно (2)");
}
Console.Write("Введите количество посящений (из 19): ");
int attendance = int.Parse(Console.ReadLine());
Console.Write("Введите средний балл по практике: ");
double practiceGra = double.Parse(Console.ReadLine());
bool goodAttendance = attendance >= 14;
bool goodGrades = practiceGra >= 3.0;
if (goodAttendance && goodGrades) {
    Console.WriteLine("+ Допуск к экзамену развершен.");
}
else if (!goodAttendance && goodGrades) {
    Console.WriteLine("- Недостаточно посящений. Нужно отработать пропуски.");
}
else if (!goodAttendance && !goodGrades) {
    Console.WriteLine("- Низкий балл по практите. Нужно пересдать работы.");
}
else {
    Console.WriteLine("- Проблемы и с посящением и с оценками мРОЧНО К ПРЕПОДУ ");
}