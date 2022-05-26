// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива


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

// Метод сортировки массива по убыванию
int[,] Streamline(int[,] list)
{
    for (int j = 0; j < list.GetLength(0); j++)
    {
        for (int k = 1; k < list.GetLength(1); k++)
        {
            int maxIndex = k;
            int startIndex = k - 1;
            for (int i = startIndex; i < list.GetLength(1); i++)
            {
                if (list[j, i] > list[j, maxIndex]) maxIndex = i;
            }

            int temp = list[j, k - 1];
            list[j, k - 1] = list[j, maxIndex];
            list[j, maxIndex] = temp;
        }
    }
    return list;
}


Console.Write("Введите число строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = Create(a, b);
Console.WriteLine("Исходный массив: ");
PrintArr(array);
Console.WriteLine("Отсортированный массив:");
Streamline(array);
PrintArr(array);


