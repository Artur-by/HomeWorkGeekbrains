// Задача 2: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях

Console.WriteLine("Введите количество элементов массива: ");
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
        arr[i] = new Random().Next(0, 10);
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

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] array = CreatArr(N);
FillArr(array);
ReadArr(array);
System.Console.WriteLine($"сумма нечетных позиций массива равна {Sum(array)} ");

