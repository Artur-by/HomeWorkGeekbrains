// В матрице чисел найти сумму элементов главной диагонали

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

//метод вывода элементов массива в консоль
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

// метод подсчета суммы элементов на гл.диогонале
void Summ(int[,] arr)
{
    int sum = 0;
    int len = arr.GetLength(0); // len -наменьшая сторона матрицы
    if (arr.GetLength(0) > arr.GetLength(1)) len = arr.GetLength(1);
    for (int i = 0; i < len; i++)
    {
        sum = sum + arr[i, i];
        Console.Write($" {arr[i, i]} ");
    }
    Console.WriteLine($" = {sum}");

}

int[,] array = Create(a, b);
PrintArr(array);
Console.WriteLine("Сумма элементов главной диогонали равна :");
Summ(array);