Console.WriteLine("* * * Начало работы программы * * *");
Console.WriteLine("* * * ВВедите M (N) - кол-во чисел для ввода и нажмите ENTER* * *");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
    Console.WriteLine("* * * ВВедите M чисел* * *");
int count = 0;
for (int i = 0; i < M; i++){
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"* ОК, осталось ввести {M-i-1} чисел*");
    if (array[i] > 0) {
        count ++;
    }
}

Console.WriteLine($"чисел больше нуля = {count}");
Console.WriteLine("* * * Работа программы завершена * * *");