//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника * 
// Показать только нечетные числа в треугольнике
Console.Write("введите длинну основания треугольника: ");
int baseTreangle = Convert.ToInt32(Console.ReadLine());
while (baseTreangle % 2 == 0)
{
    Console.WriteLine("длина основания должна быть нечетной! ");
    Console.WriteLine("введите длинну основания треугольника: ");
    baseTreangle = Convert.ToInt32(Console.ReadLine());
}


// метод вывода в консоль 2х мерного массива
// с учетом только нечетных значений
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) Console.Write($"   ");
            else Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// создаем 2х мерный массив согласно длинне треугольника
int[,] array = new int[baseTreangle / 2 + 1, baseTreangle];
// отмечаем вершины треугольника 
array[0, array.GetLength(1) / 2] = 1;
array[array.GetLength(0) - 1, 0] = 1;
array[array.GetLength(0) - 1, array.GetLength(1) - 1] = 1;


// метод заполнения матрицы Паскаля
int[,] PascalFill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 2; j++)
        {
            array[i + 1, j + 1] = array[i, j] + array[i, j + 2];
        }
    }
    return array;
}


PascalFill(array);
PrintArray(array);


