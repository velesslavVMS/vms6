// See https://aka.ms/new-console-template for more information
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = Math.Round ((b1-b2)/(k2-k1), 4);
Console.WriteLine($"Точка пересечения двух прямых: x={x}, y1={(Math.Round(k1*x+b1), 4)}, y2={(Math.Round(k2*x+b2), 4)}");