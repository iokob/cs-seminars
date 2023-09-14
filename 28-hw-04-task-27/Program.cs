Console.WriteLine("* * * Введите число N и нажмите enter * * *");
int N = Convert.ToInt32(Console.ReadLine());
int countDigits (int number) {
    return Convert.ToInt32(Math.Log10(number)) + 1;
}
int SumDigits(int N){
    int sum = 0;
    int cd = countDigits(N);
    for (int i = 1; i <= cd; i++ ){        
        sum = sum + N % 10;  
        N = N / 10;    
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {N} равно {SumDigits(N)}");

Console.WriteLine("* * * Работа программы завершена * * *");