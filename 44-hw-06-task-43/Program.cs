Console.WriteLine("* * * Начало работы программы * * *");
Console.WriteLine("* y = k1 * x + b1 *");
Console.WriteLine("* Введите k1 и нажмите ENTER *");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* Введите b1 и нажмите ENTER *");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* y = k2 * x + b2 *");
Console.WriteLine("* Введите k2 и нажмите ENTER *");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* Введите b2 и нажмите ENTER *");
double b2 = Convert.ToInt32(Console.ReadLine());
double[] pos = new double[2];
double[] calcPos (double k1, double b1, double k2, double b2) {
    double x = 0;
    double y = 0;
    double[] pos = new double[2];
    x = (b2-b1)/(k1-k2);
    pos[0] = x;
    y = (k1*b2 - k2*b1)/(k1-k2);
    pos[1] = y;
    return pos;
}

void printArrayLine(double[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(string.Format("{0:0.00}", array[i]) + " ");
    }
    Console.WriteLine(" ");
}
pos = calcPos(k1, b1, k2, b2);
printArrayLine(pos);
Console.WriteLine("* * * Работа программы завершена * * *");