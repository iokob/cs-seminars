Console.WriteLine("* * * Введите трёхзначное число и нажмите enter * * *");
int number = Convert.ToInt32(Console.ReadLine());
int func(int a) {
    return (a / 10) % 10;
}
Console.WriteLine("Вторая цифра числа " + func(number));
Console.WriteLine("* * * Работа программы завершена * * *");