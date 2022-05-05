// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(1, 11);
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

int CountSum(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i = i + 2)
    {
        count = count + list[i];
    }
    return count;
}

int[] array = CreateList(N);
PrintList(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях равна {CountSum(array)}");