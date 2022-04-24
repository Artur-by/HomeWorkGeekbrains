// программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Cube(int i)
{
    return i * i * i;
}

int N = -5;

if (N < 0) N = -N;
for (int i = 1; i <= N; i++)
{
    int cub = Cube(i);
    Console.WriteLine(cub);
}