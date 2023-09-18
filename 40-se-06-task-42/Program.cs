Console.WriteLine("* * * Начало работы программы * * *");
Console.WriteLine("* * * Введите десятичное число * * *");
int num = Convert.ToInt32(Console.ReadLine());
string decToBin(int num){
    string result = String.Empty;
    int temp = 0;
    for (int i = num; i > 0; i/=2){
        temp = i%2;
        result = temp + result;
    }
    return result;
}

Console.WriteLine($"{decToBin(num)}");    
Console.WriteLine("* * * Работа программы завершена * * *");    