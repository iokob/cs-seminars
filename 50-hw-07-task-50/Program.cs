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

string output(int i, int j, double[,]array){
    if ((i >= 0) && (i < array.GetLength(0))) {
        if ((i >= 0) && (j < array.GetLength(1))){
            return String.Format("{0:0.00}", array[i,j]);
        }
    } 
        return "Такого элемента нет";
}

double[,] array = getRandom2DArray(5,5,10);
print2DArray(array);
Console.WriteLine("* Введите индексы элемента двумерного массива *");
Console.WriteLine("* i = *");
int ii = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* i = *");
int ij = Convert.ToInt32(Console.ReadLine());

string outstr = output(ii,ij,array);
Console.WriteLine($"{outstr}");
Console.WriteLine("* * * Работа программы завершена * * *");