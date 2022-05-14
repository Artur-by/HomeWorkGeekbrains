// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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
            arr[i, j] = new Random().Next(-9, 10);
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

// метод замены элементов, у которых оба индекса чётные
int[,] Replace(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 & j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}

int[,] arr = CreateArr(m, n);
Console.WriteLine("Исходный массив:");
PrintArr(arr);
Console.WriteLine("Измененный массив:");
Replace(arr);
PrintArr(arr);