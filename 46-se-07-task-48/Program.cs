Console.WriteLine("* * * Начало работы программы * * *");
Console.WriteLine("* Введите размер массива M x N *");
Console.WriteLine("* M = *");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* N = *");
int N = Convert.ToInt32(Console.ReadLine());

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

int[,] array = get2DArray(5,5);
print2DArray(array);
Console.WriteLine("* * * Работа программы завершена * * *");