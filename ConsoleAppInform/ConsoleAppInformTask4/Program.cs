//task 4

Console.Write("Введите число x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число n: ");
double n = Convert.ToDouble(Console.ReadLine());

double y = 1;

for (int i = 1; i <= n; i++)
{
    y += Math.Log10(Math.Pow(x, i - 1)) / (Math.Pow(-1, i) / x);
}
Console.Write(y + "\n");