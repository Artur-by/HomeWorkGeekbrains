// Написать программу копирования массива

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
// создаем массив из рандомных n чисел
int[] arr = new int[n];
for (int i = 0; i < n-1; i++)
{
    arr[i] = new Random().Next(-10,10);
}

// создаем новый массив и копируем его элементы
int[] newarr = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    newarr[i] = arr[i];
}

// метод вывода элементов на печать
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} |");
    }
}

Console.WriteLine("Созданный массив: ");
PrintArr(arr);
Console.WriteLine();
Console.WriteLine("Скопированный массив: ");
PrintArr(newarr);