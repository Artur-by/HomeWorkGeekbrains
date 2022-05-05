//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(1, 11);
    }
    return list;
}

// метод вывода элементов массива на печать
void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($" {list[i]}|");
    }
}

void NewArr(int[] list)
{
    //int[] newlist = new int[list.Length];
    int count = list.Length - 1;
    for (int i = 0; i < list.Length / 2; i++)
    {
        Console.WriteLine($"{list[i]} * {list[count]} = {list[i] * list[count]}");
        count--;
    }
}

int[] array = CreateList(N);
PrintList(array);
Console.WriteLine();
NewArr(array);