/*Пусть стороны треугольника: a, b, c.
Опустим перпендикуляр  y из угла (ab) на сторону c.
Тогда S_triangle=c*y/2.*/
Console.Write("Введите координату x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());

double a = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)); 
double b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)); 
double c = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); 
Console.WriteLine($"a= {a}, b= {b}, c= {c}");
if(a+b>c && a+c>b && b+c>a)
{
double x = Math.Round ((Math.Pow(a, 2) - Math.Pow(b, 2) - Math.Pow(c, 2))/(2*c), 4);
Console.WriteLine($"x= {x}");
double y = Math.Round (Math.Sqrt(Math.Pow(b, 2) - Math.Pow(x, 2)), 4); 
Console.WriteLine($"y= {y}");
double S = Math.Round (c*y/2, 4);
Console.WriteLine($"S= {S}");
//Console.WriteLine($"Площадь треугольника равна: {S}");
}
else
 Console.WriteLine("Данные точки не образуют треугольника (лежат на одной прямой)"); 
