Console.WriteLine("* * * Введите число от 1 до 7 и нажмите enter * * *");
byte number = Convert.ToByte(Console.ReadLine());
bool func(byte a) {
    if (a >= 6) {
        return true;
    }
    else return false;
}
Console.WriteLine(func(number));
Console.WriteLine("* * * Работа программы завершена * * *");