// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N

int N = 7;

int Square(int num)
{
    return num * num;
}

if (N < 0) N = -N;
int ind = 1;
while (ind <= N)
{
    Console.WriteLine(Square(ind));
    ind++;
}