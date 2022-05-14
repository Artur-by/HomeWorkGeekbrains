// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

int[,] Replace(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
    return arr;
}


int[,] array = Create(a, b);
Console.WriteLine("Заданный массив:");
PrintArr(array);
if (a != b) Console.WriteLine("Заменить строки на столбцы невозможно!");
else
{
    Replace(array);
    Console.WriteLine("Измененный массив:");
    PrintArr(array);
}