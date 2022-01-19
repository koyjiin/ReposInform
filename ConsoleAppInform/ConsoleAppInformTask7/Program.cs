//task 7

Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mas = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mas[i, j] = rnd.Next(0, 10);
        Console.Write(mas[i, j] + "\t");
    }
    Console.WriteLine();
}

