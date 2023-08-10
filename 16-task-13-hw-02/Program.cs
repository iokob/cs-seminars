Console.WriteLine("* * * Введите число и нажмите enter * * *");
string number = Console.ReadLine();
string func(string a) {
    if (number.Length >= 3) {
        return "Третья цифра числа: " + number[2];
    }
    else return "Третьей цифры нет";
}
Console.WriteLine(func(number));
Console.WriteLine("* * * Работа программы завершена * * *");