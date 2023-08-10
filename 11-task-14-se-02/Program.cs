Console.WriteLine("* * * Введите Число и нажмите enter * * *");
int number = Convert.ToInt32(Console.ReadLine());
bool func(int a) {
    if (a % 7 == 0 && a % 23 == 0) return true;
    else return false;
}
Console.WriteLine(func(number));
Console.WriteLine("* * * Работа программы завершена * * *");