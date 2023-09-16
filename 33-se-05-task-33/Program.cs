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

array = fillArrayRandom(array);
printArrayLine(array);
Console.WriteLine("* * * Проверить, есть ли число в массиве. Введите число: * * *");
int N = Convert.ToInt32(Console.ReadLine());

bool checkNumInArray(int N, int[] array){
    foreach (int item in array) {
        if (N == item) {
            return true;
        }
        
    }
    return false;
}

bool check = checkNumInArray(N, array);
Console.WriteLine($"число {N} содержится в массиве: {check}");
Console.WriteLine("* * * Работа программы завершена * * *");