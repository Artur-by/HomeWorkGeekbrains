// Задать массив из 8 элементов и вывести их на экран

int N = 8;
// метод создания и заполнения массива рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(-1000, 1000);
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

int[] array = CreateList(N);
PrintList(array);