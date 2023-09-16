Console.WriteLine("* * * Начало работы программы * * *");
int[] array = new int[10];
int[] fillArrayRandom(int[] array){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(-10, 11);
    }
    return array;
}
void printArrayLine(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}
int[] invertSigns(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = array[i] * -1;
    }
    return array;
}

array = fillArrayRandom(array);
printArrayLine(array);
array = invertSigns(array);
printArrayLine(array);

Console.WriteLine("* * * Работа программы завершена * * *");