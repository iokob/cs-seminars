Console.WriteLine("* * * Старт работы программы * * *");
int rnd3 = new Random().Next(100, 1000);
string func(int a) {
    string s1 = Convert.ToString(a / 100);
    string s2 = Convert.ToString(a % 10);
    return s1 + s2;
}
Console.WriteLine(rnd3 + "->" + func(rnd3));
Console.WriteLine("* * * Работа программы завершена * * *");