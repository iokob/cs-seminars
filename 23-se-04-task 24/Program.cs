Console.WriteLine("* * * Введите число А * * *");
int a = Convert.ToInt32(Console.ReadLine());
int sum1toa (int a) {
    int sum = 0;
    for (int i = 1; i <= a; i++) {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine($"сумма чисел от 1 до A = {sum1toa(a)}");

Console.WriteLine("* * * Работа программы завершена * * *");