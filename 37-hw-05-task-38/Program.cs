Console.WriteLine("* * * Начало работы программы * * *");
double[] array = new double[10];
double[] fillArrayRandom(double[] array){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.NextDouble()*100;
    }
    return array;
}
void printArrayLine(double[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(string.Format("{0:0.00}", array[i]) + " ");
    }
    Console.WriteLine(" ");
}

array = fillArrayRandom(array);
printArrayLine(array);
double rez = 0;
double calculateRez(double[] array){
    double rez = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i< array.Length; i++){
        if (min > array[i]){
            min = array[i];
        }
        if (max < array[i]){
            max = array[i];
        }
    }
    rez = max - min;
    return rez;
}

rez = calculateRez(array);

Console.WriteLine($"разница между макс и мин равна {rez}");    
Console.WriteLine("* * * Работа программы завершена * * *");    