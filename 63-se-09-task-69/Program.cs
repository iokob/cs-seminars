Console.WriteLine("* * * Начало работы программы * * *");
int powAB(int A, int B){
    if (B > 0)
    return(A * powAB(A, B-1));
    return 1;
} 

Console.WriteLine($"{powAB(2,3)}");
Console.WriteLine("* * * Работа программы завершена * * *");