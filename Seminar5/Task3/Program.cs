// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива

Console.Write("Введите количество элементов массива: ");
string str = Console.ReadLine();
int N = Convert.ToInt32(str);

int[] CreateArr(int N)
{
    int[] arr = new int[N];
    return arr;
}

int[] FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void ReadArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} |");
    }
}

// 1-й способ  поиска разницы между min и max числами
// ищем отдельными методами минимальное и максимальное числа 
int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}


// 2-й способ  поиска разницы между min и max числами


/*int Difference(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }
    }
    int difference = max - min;
    return difference;
}*/

int[] array = CreateArr(N);
FillArr(array);
ReadArr(array);
Console.WriteLine();
//Console.WriteLine($" разница между максимальным и минимальным числами массива={Difference(array)}");
int minimum = Min(array);
int maximum = Max(array);
Console.WriteLine($"разница между максимальным {maximum} и минимальным {minimum} числами массива = {maximum - minimum}");
