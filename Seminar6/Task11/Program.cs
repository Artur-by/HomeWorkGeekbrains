// В прямоугольной матрице найти строку с наименьшей суммой элементов.

// В случае одинаковых сумм в строках отображает первую

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
            arr[i, j] = new Random().Next(0, 11);
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


// метод записи суммы строк в одномерный массив
int[] SumLine(int[,] array)
{
    int[] list = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        list[i] = sum;
    }
    return list;
}

// метод поиска наименьшей суммы и соответствующей строки
int MinSum(int[] list)
{
    int min = list[0];
    int minLine = 0;
    for (int i = 1; i < list.Length; i++)
    {
        if (list[i] < min)
        {
            min = list[i];
            minLine = i;
        }
    }
    return minLine;
}

void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.WriteLine($" Сумма элементов {i + 1}-ой строки {list[i]} ");
    }
}

int[,] arr = Create(a, b);
Console.WriteLine("Созданный массив:");
PrintArr(arr);
Console.WriteLine();
int[] sumlist = SumLine(arr);
PrintList(sumlist);
Console.WriteLine($"Строка с наименьшей суммой элементов  {MinSum(sumlist) + 1}");

