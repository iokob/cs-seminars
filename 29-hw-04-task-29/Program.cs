Console.WriteLine("* * * Введите 8 чисел, разделяя их enter * * *");
int[] array = new int[8];

for (int i = 0; i < array.Length; i++) {
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++){
          Console.Write(Convert.ToInt32(array[i]) + " ");
    }
    Console.WriteLine(" ");
}

PrintArray(array);

Console.WriteLine("* * * Работа программы завершена * * *");