Console.WriteLine("* * * Введите координаты 2-х точек в 3d пространстве * * *");
Console.WriteLine("* * * Введите координаты Точки А, разделяя их enter * * *");
Console.WriteLine("* * * Ax = * * *");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("* * * Ay = * * *");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("* * * Az = * * *");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("* * * Введите координаты Точки B, разделяя их enter * * *");
Console.WriteLine("* * * Bx = * * *");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("* * * By = * * *");
double By = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("* * * Bz = * * *");
double Bz = Convert.ToDouble(Console.ReadLine());

double d12 = Math.Sqrt((Math.Pow(Bx-Ax,2)) + Math.Pow(By-Ay,2) + Math.Pow(Bz-Az,2));
Console.WriteLine($"Расстояние между точками A и B = {d12}");

Console.WriteLine("* * * Работа программы завершена * * *");