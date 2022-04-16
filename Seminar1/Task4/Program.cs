// программа, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

// предполагаем что в задче все числа целые

int N = 0;

if (N < 1)
{
    Console.WriteLine(" N вне диапазона");
}
else
{
    int count = 1;
    while (count <= N)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
            count++;
        }
        else
        {
            count++;
        }
    }
}




