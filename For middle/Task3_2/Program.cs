// Найти сумму чисел от 1 до А
// Предполагаем что А это произвольное положительно число

double A = 199_100_100_999;

// метод арифметического подсчета суммы чисел

double Count(double A)
{
    double result = 0;
    result = A * (A + 1) / 2;
    return result;
}

double a = Count(A);
Console.WriteLine($"сумма чисел числа {A} равна {a}");