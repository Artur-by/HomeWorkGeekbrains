//программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел

double NumA = 22;
double NumB = 5;
double NumC = 9;
if (NumA >= NumB)
{
    if (NumA >= NumC)
    {
        Console.Write("max = ");
        Console.WriteLine(NumA);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(NumC);
    }
}
else
{
    if (NumB >= NumC)
    {
        Console.Write("max = ");
        Console.WriteLine(NumB);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(NumC);
    }
}

