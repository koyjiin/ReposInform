// task 6

Console.Write("введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k: ");
int k = Convert.ToInt32(Console.ReadLine());

int n = 0;

Random rnd = new Random();
int[] y = new int[m];

for(int i = 0; i < y.Length; i++)
{
    y[i] = rnd.Next(-10, 10);
    Console.Write(y[i] + "\n");
}

Console.Write("Новый массив: ");

for(int i = 0; i < y.Length; i++)
{
    //n = (y[i] - y[i - 1]) - (y[i] - y[i + n]);
    int max = y.Max();
}
Console.Write(n);
