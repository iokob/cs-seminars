Console.WriteLine("* * * Введите пятизначное число * * *");
int number = Convert.ToInt32(Console.ReadLine());
int countDigits (int number) {
    return Convert.ToInt32(Math.Log10(number)) + 1;
}
int nD = countDigits(number);
int rigthDig = 0;
int leftDig = 0;
bool funcPass = false;
for (int i = 1; i <= nD/2; i++) {
    funcPass = false;
    rigthDig = number / Convert.ToInt32(Math.Pow(10, i-1)) % 10;
    leftDig = number / Convert.ToInt32(Math.Pow(10, nD-i)) % 10;

    Console.WriteLine($"Math.Pow(10, nD-1-i): {Convert.ToInt32(Math.Pow(10, nD-i))}"); 
   Console.WriteLine($"rl digs: {rigthDig} .. {leftDig}"); 
    if (rigthDig == leftDig) {
        funcPass = true;
    }
    else {
        break;
        }
    }


Console.WriteLine($"Число {number} - палиндром: {funcPass}");

Console.WriteLine("* * * Работа программы завершена * * *");