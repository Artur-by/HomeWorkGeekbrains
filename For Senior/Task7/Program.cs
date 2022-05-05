// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// Уточнить !!! необходимо подсчитывать числа, которые в диапазоне [10,99]?
int N = 123;

// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(1, 1000);
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

// метод подсчета элементов в заданном диапазоне
int Count(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] >= 10 && list[i] <= 99) count++;

    }
    return count;
}

int[] array = CreateList(N);
PrintList(array);
Console.WriteLine();
Console.WriteLine($"Количество элементов  в заданном диапазоне: {Count(array)}");