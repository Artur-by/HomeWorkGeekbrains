// Показать двумерный массив размером m×n заполненный целыми числами
// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// метод создания 2х мерного массива
double[,] CreateArr(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().NextDouble() * 20 - 10; // - рандом для double
        }
    }
    return arr;
}

// метод вывода двухмерного массива

void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}


double[,] yard = CreateArr(m, n);
PrintArr(yard);


