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

int[] rowMinSum (int[,] array) {
    int[] sumArray = new int[array.GetLength(0)];
    int[] outArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum = sum + array[i,j];
        }
        sumArray[i] = sum;
    }
    int mini = -1;
    for (int i = 0; i < sumArray.Length-1; i++) {
        if (sumArray[i+1] < sumArray[i]) {
            mini = i+1;
        }
    }
    for (int j = 0; j < array.GetLength(1); j++) {
        outArray[j] = array[mini, j];
    }
    return outArray;
}

void printArrayLine(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

int[,] array = getRandom2DArray(5,5,10);
print2DArray(array);
Console.WriteLine("* * * * * *");
int[] minSumLine = rowMinSum(array);
printArrayLine(minSumLine);


Console.WriteLine("* * * Работа программы завершена * * *");
