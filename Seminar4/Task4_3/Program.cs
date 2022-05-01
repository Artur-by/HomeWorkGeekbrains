//Программа, которая задаёт массив из 8 элементов и выводит их на экран.

int N = 8;

int[] CreatTable(int N)
{
    int[] table = new int[N];
    for (int i = 0; i < N; i++)
    {
        table[i] = i + 1;
    }
    return table;
}


int[] AddTable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        table[i] = new Random().Next(-999, 999);
    }
    return table;
}



void ReadTable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        Console.Write($" {table[i]} |");
    }
}
Console.WriteLine();

int[] tab = CreatTable(N);
tab = AddTable(tab);
Console.WriteLine("Массив из 8 цифр в диапазоне от -999 до 999 :");
ReadTable(tab);
