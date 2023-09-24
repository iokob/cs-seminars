Console.WriteLine("* * * Начало работы программы * * *");
void printNaturalN(int M, int N){
    if (N >= M) {
        printNaturalN(M, N - 1);
        Console.Write(N + " ");
    }
}

printNaturalN(5, 10);


Console.WriteLine("* * * Работа программы завершена * * *");