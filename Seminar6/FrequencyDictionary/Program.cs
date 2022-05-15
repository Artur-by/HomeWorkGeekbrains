// Составить частотный словарь элементов двумерного массива
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
            arr[i, j] = new Random().Next(0, 11);
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
// метод подсчета одинаковых элементов в масиве
// почемуто не считает нули?!
int SearchElement(int[,] arr, int element)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element) count++;
        }
    }
    return count;
}

// метод проверки , был подобный элемент или встречается впервые
bool Check(int[] list, int element)
{
    bool result = true;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == element) result = false;
    }
    return result;
}

// метод вывода списка в консоль
void PrintList(int[] namelist, int[] countlist)
{
    for (int i = 0; i < countlist.Length; i++)
    {
        if (countlist[i] != 0)
        {
            Console.WriteLine($"Число {namelist[i]} в массиве встречается {countlist[i]} раз(а)");
        }

    }
}

// запуск скрипта
int[,] array = Create(a, b);
PrintArr(array);
// создаеи списки с уникальными значениями и соответственно количеством 
int[] nameElement = new int[array.GetLength(0) * array.GetLength(1)];
int[] countElement = new int[array.GetLength(0) * array.GetLength(1)];

int countlist = 0;
int countnull = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        //если элемента нет в уникальных списках заносим их туда
        if (Check(nameElement, array[i, j]))
        {
            nameElement[countlist] = array[i, j];
            countElement[countlist] = (SearchElement(array, array[i, j]));
            countlist++;
        }
        // отдельный подсчет нулей
        if (array[i, j] == 0) countnull++;

    }
}
// добавили в список количество нулей в массиве
countElement[countlist] = countnull++;

PrintList(nameElement, countElement);