Console.WriteLine("* * * Введите координаты x и y, разделяя их enter * * *");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
if (x == 0 || y == 0) {
    Console.WriteLine("Одна или две координаты равны нулю");
} else {
    if (x > 0) {
        if (y > 0) {
            Console.WriteLine("Точка находится в I четверти");
        } else 
        if (y < 0) {
            Console.WriteLine("Точка находится в IV четверти");
        }
    } else
    if (x < 0) {
        if (y > 0) {
            Console.WriteLine("Точка находится во II четверти");
    } else 
        if (y < 0) {
            Console.WriteLine("Точка находится в III четверти");
        }
        }
}

Console.WriteLine("* * * Работа программы завершена * * *");