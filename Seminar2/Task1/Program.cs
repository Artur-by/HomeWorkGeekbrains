// Программа, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа

int N = new Random().Next(10, 99);
Console.WriteLine(N);

int NumA = N / 10;
int NumB = N % 10;

if (NumA > NumB)
{
    Console.WriteLine(NumA);
}
else
{
    Console.WriteLine(NumB);
}