// В двумерном массиве показать позиции числа, 
//заданного пользователем или указать, что такого элемента нет
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

// метод возвращает false при отсутствии заданного числа и true при наличии
// а также выводит в консоль позиции заданного числа
bool Search(int[,] arr, int input)
{
    bool pos = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == input)
            {
                Console.WriteLine($"В заданном массиве число {input} на позиции [{i},{j}]");
                pos = true;
            }
        }
    }
    return pos;
}

int[,] array = Create(a, b);
PrintArr(array);
Console.Write("Введите число: ");
int input = Convert.ToInt32(Console.ReadLine());
if (Search(array, input) == false) Console.WriteLine($"В заданном массиве нет числа {input}");