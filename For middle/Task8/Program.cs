// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] CreateArr(int N)
{
    int[] array = new int[N];
    return array;
}

int[] FillArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        array[i] = array[i] * array[i] * array[i];
    }
    return array;
}

void ReadeArr(int[] array)
{
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} |");
    }
}

void CubeArr(int[] arr)
{
    Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) Console.Write($"{arr[i]} |");
    }
}

int[] array = CreateArr(N);
FillArr(array);
ReadeArr(array);
Console.WriteLine();
CubeArr(array);