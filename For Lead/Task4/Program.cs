// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2
// b1, k1 и b2 и k2 заданы

/*для нахождения пересечения 2х прямых нужно найти общие точки x и y 
k1*x +b1 = k2*x +b2
k1*x - k2*x = b2-b1
x(k1-k2) = b2-b1
x= (b2-b1)/(k1-k2) 
*/


Console.Write("Введите угловой коэффициент k1 для первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите действительное число b1 для первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите угловой коэффициент k2 для второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите действительное число b2 для второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());


if (k1 == k2) Console.WriteLine(" Прямые не пересекаются!");
else
{
    double x = ((b2 - b1) / (k1 - k2));
    double y = k1 * x + b1;
    Console.WriteLine("Точка пересечения 2х прямых:");
    Console.WriteLine($"x: ({b2}-{b1})/({k1}-{k2}) = {Math.Round((decimal)x, 2)}");
    Console.WriteLine($"y:  {k1} * {Math.Round((decimal)x, 2)} +  {b1} = {Math.Round((decimal)y, 2)}");
}






