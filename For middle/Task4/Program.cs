// Возведите число А в натуральную степень B используя цикл

double A = 2;
int B = 10;

double Digree(double A, int B)
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine($"{A} в сепени {B} равно {Digree(A, B)}");
