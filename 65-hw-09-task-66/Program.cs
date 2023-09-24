Console.WriteLine("* * * Начало работы программы * * *");
int sumFromMtoN(int M, int N){
    if (M <= N)
    return(M + sumFromMtoN(M+1, N));
    return 0;
} 

Console.WriteLine($"{sumFromMtoN(2,6)}");
Console.WriteLine("* * * Работа программы завершена * * *");