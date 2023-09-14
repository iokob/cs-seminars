Console.WriteLine("* * * Введите числа A и B разделяя их enter * * *");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} равно {Math.Pow(A, B)}");

Console.WriteLine("* * * Работа программы завершена * * *");