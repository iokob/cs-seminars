Console.WriteLine("* * * Введите число N * * *");
int N = Convert.ToInt32(Console.ReadLine());
int calc (int n){
    int res = 1;
    for (int i = 1; i <= n; i++){
        res = res * i;
    }
    return res;
}

Console.WriteLine($"количество произведение чисел от 1 до {N} равно {calc(N)}");

Console.WriteLine("* * * Работа программы завершена * * *");