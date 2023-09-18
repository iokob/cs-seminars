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
int[] invertArray(int[] array){
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++) {
        temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
    return array;
}

array = fillArrayRandom(array);
printArrayLine(array);
array = invertArray(array);
printArrayLine(array);
    
Console.WriteLine("* * * Работа программы завершена * * *");    