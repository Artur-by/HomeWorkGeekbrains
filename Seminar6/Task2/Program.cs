// В двумерном массиве n×k заменить четные элементы на противоположные

Console.Write("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int k = Convert.ToInt32(Console.ReadLine());

// метод создания 2х мерного массива
int[,] CreateArr(int n, int k)
{
    int[,] arr = new int[n, k];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            arr[i, j] = new Random().Next(-10, 11);
        }
    }
    return arr;
}

// метод вывода двухмерного массива

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Способ 1, простой - замена четных значений элементов массива
int[,] Replace1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
        }
    }
    return array;
}

// Способ 2, заменв элементов массива на четных позициях каждой строки
int[,] Replace2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j = j + 2)
        {
            array[i, j] = -array[i, j];
        }
    }
    return array;
}

// Способ 3, замороченный замена элементов массива на четных позициях с переходом на новые строки
int[,] Replace3(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 1; j < array.GetLength(1); j = j + 2)
            {
                array[i, j] = -array[i, j];
            }
        }
        else
        {
            for (int j = 0; j < array.GetLength(1); j = j + 2)
            {
                array[i, j] = -array[i, j];
            }
        }
    }
    return array;
}



int[,] arr = CreateArr(n, k);
Console.WriteLine("Первоначальный массив:");
PrintArr(arr);

/*
// Способ 1
Change(arr);
Console.WriteLine("Замена четных значений массива:");
PrintArr(newarr);*/

// Способ2
/*Replace2(arr);
Console.WriteLine("Замена четных позиций массива:");
PrintArr(arr);*/

// Способ 3
if (arr.GetLength(1) % 2 == 0) Replace2(arr);
else Replace3(arr);
Console.WriteLine("Замена четных позиций массива с переводом на новую строку:");
PrintArr(arr);


