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

int[,] changeArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i = i+2){
        for (int j = 0; j < array.GetLength(1); j = j+2) {
            array[i,j] = array[i,j] * array[i,j];
        }
    }
    return array;
}

int[,] array = get2DArray(M,N);
print2DArray(array);
Console.WriteLine("* * * * * *");
array = changeArray(array);
print2DArray(array);
Console.WriteLine("* * * Работа программы завершена * * *");