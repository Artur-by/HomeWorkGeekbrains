// Показать числа Фибоначчи
Console.WriteLine("Числа Фибоначчи: ");

double first = 0;
double second = 1;
Console.WriteLine(first);
Console.WriteLine(second);

int i = 200;
while (i > 0)
{
    double next = first + second;
    Console.WriteLine(next);
    first = second;
    second = next;
    i--;
}
