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

double[] getAverFromColumns(double[,] array) {
    double[] aver = new double[array.GetLength(1)];
    for (int i = 0; i < aver.Length; i++) {
        aver[i] = 0;
    }
    
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            aver[j] = (aver[j] + array[i,j]/array.GetLength(0));
        }
    }
    return aver;
}

void printArrayLine(double[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(string.Format("{0:0.00}", array[i]) + " ");
    }
    Console.WriteLine(" ");
}

double[,] array = getRandom2DArray(5,2,10);
print2DArray(array);
Console.WriteLine("* * * * * *");
double[] aver = getAverFromColumns(array);
printArrayLine(aver);

Console.WriteLine("* * * Работа программы завершена * * *");