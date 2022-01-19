//task 2

Console.Write("Введите число x: ");
double x = Convert.ToDouble(Console.ReadLine());

double sqrt = Math.Sqrt(Math.Abs(2 * Math.Pow(x, 2) - Math.Abs(Math.Sin(x)) * Math.Tan(x)));
double pow_sqrt = Math.Pow(sqrt, 5);
double a = pow_sqrt * Math.Pow(2.5, Math.Cos(x));

double b = 0.625 + 2 * Math.Log2(x + 7.5);

double y = a / b;

Console.WriteLine(y);
