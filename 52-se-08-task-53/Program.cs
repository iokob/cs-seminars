Console.WriteLine("* * * Начало работы программы * * *");

double[,] getRandom2DArray(int rowNumber, int colNumber, double deviation){
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++){
        for (int j = 0; j < colNumber; j++){
            result[i,j] = new Random().NextDouble() * deviation;
        }
    }
    return result;
}

void print2DArray (double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            System.Console.Write(String.Format("{0:0.00}", array[i,j]) + " ");
        }
        System.Console.WriteLine();
    }
}

double[,] array = getRandom2DArray(5,2,10);
print2DArray(array);
Console.WriteLine("* * * * * *");
double[,] swapLines(double[,] array){
    double temp = 0;
    for (int j = 0; j < array.GetLength(1); j++) {
        temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
    return array;
}
array = swapLines(array);
print2DArray(array);
Console.WriteLine("* * * Работа программы завершена * * *");