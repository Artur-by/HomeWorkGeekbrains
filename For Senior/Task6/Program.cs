// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());


// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(100, 1000);
    }
    return list;
}

// метод вывода элементов массива на печать
void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($" {list[i]}|");
    }
}

// метод подсчета количество четных элементов массива 

int EvenCount(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = CreateList(N);
PrintList(array);
Console.WriteLine();
int ecount = EvenCount(array);

Console.WriteLine($"Количество четных элементов массива {ecount} ");
Console.WriteLine($"Количество нечетных элементов массива {N - ecount} ");

