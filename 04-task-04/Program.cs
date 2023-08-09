Console.WriteLine("Введите натуральное число N");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -number; i <= number; i++)   {
    Console.Write(i + " ");
}