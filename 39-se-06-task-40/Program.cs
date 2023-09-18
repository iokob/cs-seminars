Console.WriteLine("* * * Начало работы программы * * *");
Console.WriteLine("* * * Введите длины сторон треугольника, разделяя их ENTER * * *");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());
double c = Convert.ToInt32(Console.ReadLine());
bool isExist(double a, double b, double c){
    if ((a+b > c) && (a+c > b) && (b+c > a) ) {
        return true;
    }
    else {
        return false;
    }
}

Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует: {isExist(a, b, c)}");    
Console.WriteLine("* * * Работа программы завершена * * *");    