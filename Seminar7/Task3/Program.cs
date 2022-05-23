// Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента

Console.Write("Введите длину массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int d = Convert.ToInt32(Console.ReadLine());
while (a * b * d > 99)
{
    Console.WriteLine("Количество элементов массива превышает");
    Console.WriteLine("количество не повторяющихся двузначных чисел!");
    Console.Write("Введите новую длину массива: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите новую ширину массива: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите новую высоту массива: ");
    d = Convert.ToInt32(Console.ReadLine());
}
const int cellWidth = 3;

// метод создания массива
int[,,] Create(int a, int b, int d)
{
    int[,,] arr = new int[a, b, d];
    int num = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = num++;
            }
        }
    }
    return arr;
}

//метод вывода элементов массива в консоль
void PrintArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($" {arr[i, j, k],cellWidth} ({i}:{j}:{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix = Create(a, b, d);
PrintArr(matrix);