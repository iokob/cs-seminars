Console.WriteLine("* * * Начало работы программы * * *");

int[,] getRandom2DArray(int rowNumber, int colNumber, int deviation){
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++){
        for (int j = 0; j < colNumber; j++){
            result[i,j] = new Random().Next(0, deviation);
        }
    }
    return result;
}

void print2DArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int findInArray(int[,] array, int num) {
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == num) {
                    count++;
                }
            }
        }
    return count;
}

int[,] array = getRandom2DArray(5,5,10);
print2DArray(array);
Console.WriteLine("Введите элемент массива, который хотите посчитать");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
count = findInArray(array, num);
Console.WriteLine($"элемент '{num}' встречается в массиве {count} раз");
Console.WriteLine("* * * Работа программы завершена * * *");
