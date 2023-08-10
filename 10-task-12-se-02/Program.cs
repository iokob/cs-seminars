Console.WriteLine("* * * Введите 2 целых числа, разделяя их enter * * *");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
void func(int a, int b) {
    if (b % a == 0) {
        Console.WriteLine("Второе число кратно первому");
    } 
    else {
        Console.WriteLine("Остаток от деления = " + b % a);
    }
}
func(a, b);
Console.WriteLine("* * * Работа программы завершена * * *");