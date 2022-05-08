// Выяснить являются ли три числа сторонами треугольника

Console.Write("Введите длину первой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третей стороны треугольника: ");
int d = Convert.ToInt32(Console.ReadLine());


// метод срравнения длин сторон
bool Comparsion(int a, int b, int d)
{
    bool result = true;
    if (a + b <= d) return result = false;
    return result;
}

// Способ 1:
/*if (Comparsion(a, b, d) == false) Console.WriteLine("Введенные три числа не могут образовать треугольник");
else
{
    if (Comparsion(b, d, a) == false) Console.WriteLine("Введенные три числа не могут образовать треугольник");
    else
    {
        if (Comparsion(a, d, b) == false) Console.WriteLine("Введенные три числа не могут образовать треугольник");
        else Console.WriteLine("Введенные три числа являются сторонами треугольника");
    }
}*/

//Способ 2:
bool result = true;
while (true)
{
    result = (Comparsion(a, b, d));
    if (result == false) break;
    result = Comparsion(a, d, b);
    if (result == false) break;
    result = Comparsion(d, b, a);
    break;
}
if (result == true) Console.WriteLine("Введенные три числа являются сторонами треугольника");
else Console.WriteLine("Введенные три числа не могут образовать треугольник");



