// Написать программу замену элементов массива на противоположные
// Предполагаем что "противоположные" это с противоположным знаком +на-

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(-100, 101);
    }
    return list;
}

// метод замены элементов масссива
int[] Change(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = -list[i];
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

int[] arr = CreateList(N);
Console.WriteLine("Исходный массив:");
PrintList(arr);
Console.WriteLine();
Console.WriteLine("Измененный массив:");
PrintList(Change(arr));
