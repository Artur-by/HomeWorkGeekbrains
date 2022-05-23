// В двумерном массиве целых чисел. Удалить строку и столбец,
// на пересечении которых расположен наименьший элемент

// алгоритм поиска следующий:
// 1. ищем минимальный элемент;
// 2. в одномерный массив записываем координаты первого минимального числа
// 3. создаем новый пустой массив с количеством строк и столбцов меньше на 1 первонвчального
// 4. в новый массив записываем только те числа, которые не принадлежат координатам мин.числа
// 5. запускаем цикл с новой проверкой наличия мин.числа и перезаписи массива  


Console.Write("Введите число строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
const int cellWidth = 3;

// метод создания массива
int[,] Create(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 20);
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
            Console.Write($" {arr[i, j],cellWidth} ");
        }
        Console.WriteLine();
    }
}

// метод поиска минимального элемента
int SearchMin(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) min = array[i, j];
        }
    }
    return min;
}


// метод записи в массив индексов координаты минимального числа
int[] SearchIndexMin(int[,] array, int min)
{
    int[] indexArr = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == min)
            {
                indexArr[0] = i;
                indexArr[1] = j;
                Console.WriteLine($"Координаты минимального числа: {indexArr[0]}:{indexArr[1]}");
                return indexArr;
            }
            // в массив записываем -1, для проверки  мин.числа
            else indexArr[0] = -1;

        }
    }
    return indexArr;
}

// метод "удаления строки и столбца"
int[,] NewFillMatrix(int[,] matrix, int[] index)
{
    // создания нового пустого массива и его начальных координат
    int[,] newMatrix = new int[a - 1, b - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != index[0] & j != index[1])
            {
                newMatrix[m, n] = matrix[i, j];
                if (n < b - 2) { n++; }
                else { m++; n = 0; }
            }
        }
    }
    return newMatrix;
}


int[,] matrix = Create(a, b);
Console.WriteLine("Первоначальная матрица: ");
PrintArr(matrix);
int min = SearchMin(matrix);
Console.WriteLine($"Минимальное число:  {min}");
// счетчик count для отображения в консоли количества преобразованных массивов   
int count = 1;

while (true)
{
    int[] index = SearchIndexMin(matrix, min);
    if (index[0] != -1)
    {
        int[,] newmatrix = NewFillMatrix(matrix, index);
        Console.WriteLine($"Матрица с удаленными строкой и столбцом {count}-го минимального элемента");
        PrintArr(newmatrix);
        a--;
        b--;
        count++;
        matrix = newmatrix;
    }
    else break;

}


