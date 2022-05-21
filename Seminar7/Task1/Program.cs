// Спирально заполнить двумерный массив:
/*  1  2  3  4
    12 13 14  5
    11 16 15  6
    10  9  8  7 */

Console.WriteLine("Двумерный массив должен быть не меньше 2х2!");
Console.Write("Введите число строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());

// метод создания массива
int[,] Create(int a, int b)
{
    int[,] arr = new int[a, b];
    return arr;
}

//метод вывода элементов массива в консоль
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// метод заполнения периметра массива по часовой стрелке
// в метод передаем сам массив, count - последнее число в периметре ,
// и старотовые индексы начала обхода массива
// в методе a и b длина стороны матрицы
int FillArray(int[,] arr, int count, int startI, int startJ)
{
    // добавляем элементы слева направо
    for (int j = startJ; j < b; j++)
    {
        if (arr[startI, j] == 0) arr[startI, j] = count;
        count++;
    }
    //  добавляем элементы сверху вниз
    for (int i = startI + 1; i < a; i++)
    {
        if (arr[i, b - 1] == 0) arr[i, b - 1] = count;
        count++;
    }
    //добавляем элементы справа налево
    for (int j = b - 2; j >= startJ; j--)
    {
        if (arr[a - 1, j] == 0) arr[a - 1, j] = count;
        count++;
    }
    // добавляем элементы снизу вверх
    for (int i = a - 2; i > startI; i--)
    {
        if (arr[i, startJ] == 0) arr[i, startJ] = count;
        count++;
    }
    // возвращаем последнее заполненное число
    return count;
}





int[,] arr = Create(a, b);
int count = 1;
int startI = 0;
int startJ = 0;

// цикл перебирает и заполняет значениями периметры прямоуголиков
// от внешнего к внутренним
while (a > 1 & b > 1)
{
    count = FillArray(arr, count, startI, startJ);
    a--;
    b--;
    startI++;
    startJ++;

}

Console.WriteLine("Спирально заполненный двумерный массив:");
PrintArr(arr);
