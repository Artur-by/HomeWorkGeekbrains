// Определить, присутствует ли в заданном массиве, некоторое число

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());



// метод создания и заполнения массива  рандомными числами
int[] CreateList(int N)
{
    int[] list = new int[N];
    for (int i = 0; i < N; i++)
    {
        list[i] = new Random().Next(-100, 101);
    }
    return list;
}

void ReadeArr(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($" {list[i]} |");
    }
}

string Search(int[] list, int A)
{
    string answer;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == A)
        {
            return answer = "Заданное число присутствует в массиве";
        }
    }
    return answer = "Заданное число отсутствует в массиве";
}

int[] array = CreateList(N);
ReadeArr(array);
Console.WriteLine();

Console.WriteLine("Введите произвольное число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Search(array, A));

