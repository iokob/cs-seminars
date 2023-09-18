Console.WriteLine("* * * Начало работы программы * * *");
int[] array = new int[10];
int[] rezArray = new int[5];
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

int[] calculateRez(int[] array, int[] rezArray){

    for (int i = 0; i < array.Length / 2; i++){
        rezArray[i] = array[array.Length-1-i] * array[i];
    }
    return rezArray;
}

rezArray = calculateRez(array, rezArray);
printArrayLine(rezArray);

Console.WriteLine("* * * Работа программы завершена * * *");