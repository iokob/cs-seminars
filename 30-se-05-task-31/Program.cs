Console.WriteLine("* * * Введите 8 чисел, разделяя их enter * * *");
int[] array = new int[12];
Random random = new Random();
int sumNeg = 0;
int sumNonNeg = 0;
for (int i = 0; i < array.Length; i++){
    array[i] = random.Next(-9, 10);
    if (array[i] < 0) {
        sumNeg = sumNeg + array[i];
    } else if
        (array[i] > 0) {
            sumNonNeg = sumNonNeg + array[i];
        }
}


Console.WriteLine($"Сумма отрицательных чисел равна {sumNeg}");
Console.WriteLine($"Сумма неотрицательных чисел равна {sumNonNeg}");

Console.WriteLine("* * * Работа программы завершена * * *");