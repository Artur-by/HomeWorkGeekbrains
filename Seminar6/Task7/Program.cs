// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

Console.Write("Введите число строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

// метод создания массива
int[,] Create(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

//метод вывода элементов массива в консоль
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}

// метод подсчета ср.арифметического одного столбца
double Summ(int[,] arr, int column)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i, column];
    }
    sum = sum / arr.GetLength(0);
    return Math.Round(sum, 2);
}

int[,] newarr = Create(a, b);
PrintArr(newarr);

for (int i = 0; i < newarr.GetLength(1); i++)
{
    Console.WriteLine($"Среднее арифметическое  {i + 1} столбца = {Summ(newarr, i)}");
}