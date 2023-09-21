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

double[,] tranformArray(double[,] array){
    if (array.GetLength(0) == array.GetLength(1)) {
        double[,] outArray = new double[array.GetLength(1), array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                outArray[j, i] = array[i, j];
            }
        }
        return outArray;
    }
    else {
        return array;
    }
}

double[,] array = getRandom2DArray(5,5,10);
print2DArray(array);
Console.WriteLine("* * * * * *");
if (array.GetLength(0) != array.GetLength(1)) {
    Console.WriteLine("перестановка строк со столбцами невозможна");
} 
else {
    array = tranformArray(array);
    print2DArray(array);
}

Console.WriteLine("* * * Работа программы завершена * * *");


