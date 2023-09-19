Console.WriteLine("* * * Начало работы программы * * *");
int M = 6;
int N = 6;

int[,] get2DArray(int rowNumber, int colNumber){
    int [,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++){
        for (int j = 0; j < colNumber; j++){
            result[i,j] = i + j;
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

int calculate(int[,] array) {
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++) {
            if (i == j) {
                sum = sum + array[i, j];
            } 
        }
    }
    return sum;
}

int[,] array = get2DArray(M,N);
print2DArray(array);
int sum  = calculate(array);
Console.WriteLine($"сумма элементов на диагонали равна {sum}");
Console.WriteLine("* * * Работа программы завершена * * *");