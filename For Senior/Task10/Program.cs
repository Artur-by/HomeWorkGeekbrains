// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// 
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(1, 101);
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

//Способ1 , создаем 2 отдельных метода по поиску мин и макс
int MiniNum(int[] list)
{
    int minimum = list[0];
    for (int i = 1; i < list.Length; i++)
    {
        if (list[i] < minimum) minimum = list[i];
    }
    return minimum;
}

int MaxiNum(int[] list)
{
    int maximum = list[0];
    for (int i = 1; i < list.Length; i++)
    {
        if (list[i] > maximum) maximum = list[i];
    }
    return maximum;
}

// Способ 2, разницу считаем в одном методе
/*void Difference(int[] list)
{
    int min = list[0];
    int max = list[0];
    for (int i = 1; i < list.Length; i++)
    {
        if (list[i] < min) min = list[i];
        if (list[i] > max) max = list[i];
    }
    Console.WriteLine($"разница между максимальным числом ({max}) и минимальным ({min}) равна {max - min}");
}*/






int[] array = CreateList(N);
PrintList(array);
Console.WriteLine();
//Difference(array);
int min = MiniNum(array);
int max = MaxiNum(array);
Console.WriteLine($"разница между максимальным числом ({max}) и минимальным ({min}) равна {max - min}");
