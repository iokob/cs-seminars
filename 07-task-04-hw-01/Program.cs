Console.WriteLine("* * * Введите 3 числа, разделяя их enter * * *");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if (max < b) {
    max = b;
}
else if (max < c) {
    max = c;
}
Console.WriteLine("Максимальное из этих трёх чисел число " + max);
Console.WriteLine("* * * Работа программы завершена * * *");