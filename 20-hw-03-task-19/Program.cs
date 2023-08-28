Console.WriteLine("* * * Введите пятизначное число * * *");
int number = Convert.ToInt32(Console.ReadLine());
bool noflag = false;

for (int i = 0; i < 5/2;) {
    if (number / (Math.Pow(10, 5-1-i)) != number % (Math.Pow(10, i+1))) {
        Console.WriteLine($"Число {number} не является палиндромом");
        noflag = true;
        break;
    } else {
        i++;
    }
    if (noflag) {break;}
    Console.WriteLine($"Число {number} является палиндромом");
}

Console.WriteLine("* * * Работа программы завершена * * *");