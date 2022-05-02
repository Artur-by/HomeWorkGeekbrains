// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве
Console.Write("Введите количество элементов массива: ");
string s = Console.ReadLine();
int N = Convert.ToInt32(s);

// метод создания пустого массива
int[] CreatArr(int N)
{
    int[] arr = new int[N];
    return arr;
}

// метод заполнения массива рандомными цифрами
int[] FillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

// метод чтения элементов массива
void ReadArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
    Console.WriteLine();
}


//метод подсчета четных чисел массива
int EvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = CreatArr(N);
FillArr(array);
ReadArr(array);
Console.WriteLine($" Количество четных элементов заданного массива равно {EvenNum(array)}");