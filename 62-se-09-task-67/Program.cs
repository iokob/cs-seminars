Console.WriteLine("* * * Начало работы программы * * *");
int DigitSum(int n){
    if (n == 0)
    return 0;

    return(n%10 + DigitSum(n/10));
}

Console.WriteLine($"{DigitSum(513)}");
Console.WriteLine("* * * Работа программы завершена * * *");