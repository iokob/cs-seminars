Console.WriteLine("* * * Начало работы программы * * *");
void printNaturalN(int n){
    if (n >= 1) {
        printNaturalN(n - 1);
        Console.Write(n + " ");
    }
}

printNaturalN(5);


Console.WriteLine("* * * Работа программы завершена * * *");