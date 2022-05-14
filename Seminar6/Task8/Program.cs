// Написать программу, которая обменивает элементы первой строки и последней строки

Console.Write("Введите число строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

// метод создания массива
int[,] Create(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

// метод вывода элементов массива в консоль
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}

// метод сохранения n-й строки 
int[] TempLine(int[,] arr, int numline)
{
    int[] line = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        line[i] = arr[numline, i];
    }
    return line;
}

int[,] array = Create(a, b);
System.Console.WriteLine("Исходный массив:");
PrintArr(array);
// сохраняем первую строку массива
int[] temp = TempLine(array, 0);

// меняем значения первой строки на последнюю
for (int i = 0; i < array.GetLength(1); i++)
{
    array[0, i] = array[array.GetLength(0) - 1, i];
}
// меняем последнюю строку на первую из temp
for (int i = 0; i < temp.Length; i++)
{
    array[array.GetLength(0) - 1, i] = temp[i];
}

Console.WriteLine("Измененный массив: ");
PrintArr(array);