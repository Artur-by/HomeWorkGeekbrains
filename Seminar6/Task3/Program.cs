// Задать двумерный массив следующим правилом: Aₘₙ = m+n
// Предполагаем что первый элемент массива имеет индекс 1:1

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// метод создания 2х мерного массива
int[,] CreateArr(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = i + j + 2;
        }
    }
    return arr;
}

// метод вывода двухмерного массива

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arr = CreateArr(m, n);
PrintArr(arr);
