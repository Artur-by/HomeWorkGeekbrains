// 2. Найти кубы чисел от 1 до N
int N = 7;

int[] CreateTable(int N)
{
    int[] table = new int[N];
    return table;
}


int[] FillTable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        table[i] = i + 1;
    }
    return table;
}

int[] Addtable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        table[i] = table[i] * table[i] * table[i];
    }
    return table;
}

void PrintTable(int[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        Console.Write($"| {table[i]}");
    }
}

int[] tab = CreateTable(N);
FillTable(tab);
PrintTable(tab);
Console.WriteLine();
Addtable(tab);
PrintTable(tab);