Console.WriteLine("* * * Введите 2 числа, разделяя их enter * * *");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
    if (a > b) {    
        Console.WriteLine("Число " + a + " большее");
        Console.WriteLine("Число " + b + " меньшее");
    }
    else if (a < b) {
        Console.WriteLine("Число " + b + " большее");
        Console.WriteLine("Число " + a + " меньшее");
    }
    else if (a == b) {
        Console.WriteLine("Числа равны");
    }
Console.WriteLine("* * * Работа программы завершена * * *");