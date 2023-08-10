Console.WriteLine("* * * Введите 2 целых числа, разделяя их enter * * *");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

bool func(int a, int b) {
    if (a == b*b || b == a*a) return true;
    else return false;
}
Console.WriteLine(func(a,b));
Console.WriteLine("* * * Работа программы завершена * * *");