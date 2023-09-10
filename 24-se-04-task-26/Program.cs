Console.WriteLine("* * * Введите число N * * *");
int N = Convert.ToInt32(Console.ReadLine());
int calcDigits (int n){
    return Convert.ToInt32(Math.Log10(n)) + 1;
}

Console.WriteLine($"количество цифр в числе равно {calcDigits(N)}");

Console.WriteLine("* * * Работа программы завершена * * *");