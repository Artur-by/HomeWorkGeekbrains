// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N

int NumA = 7;

int Square(int num)
{
    return num * num;
}

if (NumA < 0) NumA = -NumA;
int ind = 1;
while (ind <= NumA)
{
    Console.WriteLine(Square(ind));
    ind++;
}