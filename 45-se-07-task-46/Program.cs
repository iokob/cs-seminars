Console.WriteLine("* * * Начало работы программы * * *");
int[,] getRandom2DArray(int rowNumber, int colNumber, int deviation){
    int [,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++){
        for (int j = 0; j < colNumber; j++){
            result[i,j] = new Random().Next(-deviation, deviation);
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

int[,] array = getRandom2DArray(5,5,10);
print2DArray(array);
Console.WriteLine("* * * Работа программы завершена * * *");