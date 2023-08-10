Console.WriteLine("* * * Старт работы программы * * *");
int rnd = new Random().Next(10, 100);
int func(int a) {
    int s1 = a / 10;
    int s2 = a % 10;
    int max = s1;
    if (s2 > max) max = s2;
    return max;
}
Console.WriteLine(rnd + "->" + func(rnd));
Console.WriteLine("* * * Работа программы завершена * * *");