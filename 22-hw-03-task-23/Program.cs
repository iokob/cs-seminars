Console.WriteLine("* * * Введите число N * * *");
int number = Convert.ToInt32(Console.ReadLine());
int[] cubes = new int[number];

for (int i = 0; i <= number; i++) {
    cubes[i] = Convert.ToInt32(Math.Pow(i+1, 3));
Console.WriteLine($"* * * i^3 = {cubes[i]} * * *");
}




Console.WriteLine("* * * Работа программы завершена * * *");