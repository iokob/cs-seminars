Console.WriteLine("* * * Введите целое число и нажмите enter * * *");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0) {
    Console.WriteLine("Число " + N + " является чётным");
} else {
    Console.WriteLine("Число " + N + " не является чётным");
}

Console.WriteLine("* * * Работа программы завершена * * *");