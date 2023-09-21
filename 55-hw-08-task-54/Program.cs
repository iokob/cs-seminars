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

int[,] sortLines(int[,] array){
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                for (int soi = 0; soi < array.GetLength(1)-1; soi++){
                    if (array[i,soi]< array[i,soi + 1]) {
                        temp = array[i,soi+1];
                        array[i,soi+1] = array[i,soi];
                        array[i,soi] = temp;
                    }
                }
            }
    }
return array;
}

int[,] array = getRandom2DArray(5,5,10);
print2DArray(array);
Console.WriteLine("* * * * * *");
array = sortLines(array);
print2DArray(array);


Console.WriteLine("* * * Работа программы завершена * * *");
