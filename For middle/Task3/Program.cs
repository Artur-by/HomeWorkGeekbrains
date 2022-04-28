// Найти сумму чисел от 1 до А

int nummin = 1;
char nummax = 'A';

int FormatTab(char num)
{
    int nummax = Convert.ToInt16(num);
    return nummax;
}

int[] CreatTab(int nummax)
{
    int[] tab = new int[nummax];
    return tab;
}

int[] FillTab(int[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        tab[i] = i + 1;
    }
    return tab;
}

int SumTab(int[] tab)
{
    int sumTab = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sumTab = tab[i] + sumTab;
    }
    return sumTab;
}



int num = FormatTab(nummax);
int[] tab = CreatTab(num);
FillTab(tab);
int sum = SumTab(tab);


Console.WriteLine($"сумма чисел от {nummin} до {nummax}({num}) равна {sum}");

