Console.WriteLine("* * * Начало работы программы * * *");
int[] array = new int[10];
int[] arrayCopy = new int[10];

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

array = fillArrayRandom(array);
printArrayLine(array);
int[] copyArray(int[] array){
    int[] copyMatrix = new int[array.Length];
    for (int i = 0; i < array.Length; i++){
        copyMatrix[i] = array[i];
    }
    return copyMatrix;
}
arrayCopy = copyArray(array);
printArrayLine(arrayCopy);

Console.WriteLine("* * * Работа программы завершена * * *");