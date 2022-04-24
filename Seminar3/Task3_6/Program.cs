// программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int Cube(int i)
{
    return i * i * i;
}

int num = 5;

if (num < 0) num = -num;
for (int i = 1; i <= num; i++)
{
    int cub = Cube(i);
    Console.WriteLine(cub);
}