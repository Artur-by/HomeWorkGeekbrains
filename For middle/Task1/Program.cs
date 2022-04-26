// Показать таблицу квадратов чисел от 1 до N

int N = 11;

int[] CreatTable(int N)
{
    int[] table = new int[N];
    for (int i = 0; i < N; i++)
    {
        table[i] = i + 1;
    }
    return table;
}

void ReadTable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        Console.Write($"{table[i]} | ");
    }
}
Console.WriteLine();



int[] AddTable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        table[i] = table[i] * table[i];
    }
    return table;
}


int[] tab = CreatTable(N);
ReadTable(tab);
Console.WriteLine();
tab = AddTable(tab);
ReadTable(tab);
