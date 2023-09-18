Console.WriteLine("* * * Начало работы программы * * *");
Console.WriteLine("* * * Введите число N и нажмите ENTER * * *");
int N = Convert.ToInt32(Console.ReadLine());
int[] fibArray = new int[N];
int[] calcFib(int N, int[] array){
    if (N == 1) {
        array[0] = 0;
        return array;
    }
    if (N == 2) {
        array[0] = 0;
        array[1] = 1;
        return array;
    }
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++) {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void printArrayLine(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

fibArray = calcFib(N, fibArray);
printArrayLine(fibArray);

Console.WriteLine("* * * Работа программы завершена * * *");    