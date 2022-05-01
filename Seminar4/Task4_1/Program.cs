//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

Console.WriteLine("Введите число A: ");
string a = Console.ReadLine();
double A = Convert.ToDouble(a);

Console.WriteLine("Введите натуральное число B: ");
string b = Console.ReadLine();
int B = Convert.ToInt32(b);

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
