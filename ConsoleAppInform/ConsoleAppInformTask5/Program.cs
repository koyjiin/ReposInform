//task 5

Console.WriteLine("Введите число n: ");
double n = Convert.ToDouble(Console.ReadLine());

double y = 0;

double Factorial(double n)
{
    if(n == 1)
        return 1;

    return n * Factorial(n - 1);
}

while(n > 0)
{
    y += (3 * n) * (Factorial(n)) / Math.Pow(n, n);
    if ()
    {
        
    }
    Console.WriteLine(y);
}