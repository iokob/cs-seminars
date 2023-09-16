Console.WriteLine("* * * Начало работы программы * * *");
int[] array = new int[123];
int count = 0;
int[] fillArrayRandom(int[] array){
    Random random = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = random.Next(-200, 201);
    }
    return array;
}
int checkArray(int[] arrray){
    int count = 0;
    foreach(int item in array){
        if (item >= 10 && item <=99){
            count++;
        }
    }
    return count;
}
array = fillArrayRandom(array);
count = checkArray(array);
Console.WriteLine($"Количество чисел в массиве [10, 99] = {count}");
Console.WriteLine("* * * Работа программы завершена * * *");