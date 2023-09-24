Console.WriteLine("* * * Начало работы программы * * *");
int ackermann(int M, int N){
    if (M == 0)
    return N + 1;
    if (M > 0 && N == 0)
    return ackermann(M-1, 1);
    if (M > 0 && N > 0)
    return ackermann(M - 1, ackermann(M, N - 1));
    return 0;
} 

Console.WriteLine($"{ackermann(3,2)}");
Console.WriteLine("* * * Работа программы завершена * * *");