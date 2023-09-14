Console.WriteLine("* * * Начало программы * * *");

int[] array = new int[8];
int[] GetRandomArray(int[] array) {
    Random rdn = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rdn.Next(2);
    }
    return array;
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++){
          Console.WriteLine(Convert.ToInt32(array[i]));
    }
}

array = GetRandomArray(array);
PrintArray(array);


Console.WriteLine("* * * Работа программы завершена * * *");