// Подсчитать сумму цифр в числе

decimal N = 1000002.012546m;

// метод преобразования отрицательного числа в положительное
decimal Controle(decimal N)
{
    if (N < 0) return -N;
    else return N;
}

// метод преобразования числа в строку
string Convert(decimal N)
{
    string n = N.ToString();
    return n;
}

//метод подсчета суммы символов в строке без учета запятой
// перевод в int - int.Parse(n.ToString())
int Sum(string N)
{
    int sumN = 0;
    for (int i = 0; i < N.Length; i++)
    {
        if (N[i] != ',') sumN = sumN + int.Parse(N[i].ToString());

    }
    return sumN;
}

decimal n = Controle(N);
string strN = Convert(n);
Console.WriteLine($"в числе {N} сумма цифр {Sum(strN)}");
