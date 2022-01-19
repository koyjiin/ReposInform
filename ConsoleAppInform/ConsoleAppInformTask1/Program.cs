//task 1

Console.WriteLine("Введите радиус: ");
double r = Convert.ToDouble(Console.ReadLine());

double S = Math.PI * Math.Pow(r, 2);
double P = 2 * r * Math.PI;

Console.WriteLine("Площадь = " + S + "\n");
Console.WriteLine("Периметр = " + P);