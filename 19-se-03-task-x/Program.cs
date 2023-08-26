Console.WriteLine("* * * Введите номер четверти декартовой системы координат (1-4) * * *");
int quart = Convert.ToInt32(Console.ReadLine());
if (quart == 1) {
    Console.WriteLine("x > 0, y > 0");
} else
if (quart == 2) {
    Console.WriteLine("x < 0, y > 0");
} else
if (quart == 3) {
    Console.WriteLine("x < 0, y < 0");
} else
if (quart == 4) {
    Console.WriteLine("x > 0, y < 0");
}

Console.WriteLine("* * * Работа программы завершена * * *");