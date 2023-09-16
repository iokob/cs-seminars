Console.WriteLine("* * * Начало работы программы * * *");
int[] array = new int[10];
int[] fillArrayRandom(int[] array){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(100, 1000);
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
int rezCount = 0;
int calculateRez(int[] array){
    int count = 0;
    foreach (int item in array){
        if (item % 2 == 0) {
            count++;
        } 
    }
    return count;
}

rezCount = calculateRez(array);

Console.WriteLine($"кол-во чётных чисел в массиве равно {rezCount}");    
Console.WriteLine("* * * Работа программы завершена * * *");    