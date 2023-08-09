Console.WriteLine("* * * Введите целое число и нажмите enter * * *");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
for (int i = 0; i <= N; i++) {
    if (i % 2 == 0) {
        Console.WriteLine(i + " ");
    }
}
Console.WriteLine("* * * Работа программы завершена * * *");