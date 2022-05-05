// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
int N = 12;

// метод создания и заполнения массива рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(-9, 10);
    }
    return list;
}
//  способ 1 - методом подсчета сначала  положительных чисел, а потом отрицательных

int PlusSum(int[] list)
{
    int plus = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > 0) plus = plus + list[i];
    }
    return plus;
}

int MinusSum(int[] list)
{
    int minus = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] < 0) minus = minus + list[i];
    }
    return minus;
}

// Способ 2 подсчетом сумм в одном цикле и выводе в терминал
/*void Count(int[] list)
{
    int plus = 0;
    int minus = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > 0) plus = plus + list[i];
        else minus = minus + list[i];
    }
    Console.WriteLine($"в заданном массиве сумма положительных элементов равна {plus}, отрицательных {-minus} ");
}*/


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
Console.WriteLine();
//Count(array);
int plus = PlusSum(array);
int minus = MinusSum(array);
Console.WriteLine($"в заданном массиве сумма положительных элементов равна {plus}, отрицательных {-minus} ");
