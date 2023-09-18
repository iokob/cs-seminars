Console.WriteLine("* * * Начало работы программы * * *");
int[] array = new int[10];
int[] fillArrayRandom(int[] array){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(0, 10);
    }
    return array;
}
void printArrayLine(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

array = fillArrayRandom(array);
printArrayLine(array);
int rezSum = 0;
int calculateRezSum(int[] array){
    int sum = 0;
    for (int i = 0; i< array.Length; i = i+2){
        sum = sum + array[i];
    }
    return sum;
}

rezSum = calculateRezSum(array);

Console.WriteLine($"сумма нечётных элементов массива равна {rezSum}");    
Console.WriteLine("* * * Работа программы завершена * * *");    