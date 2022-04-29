// 5. Определить количество цифр в числе


decimal N = -94523.125455m;

// метод преобразования отрицательного числа в положительное
decimal Controle(decimal N)
{
    if (N < 0) return -N;
    else return N;
}

// метод преобразования числа в строку
string Convert(decimal N)
{
    string q = N.ToString();
    return q;
}

//метод подсчета символов в строке без учета запятой
int Count(string N)
{
    int count = 0;
    for (int i = 0; i < N.Length; i++)
    {
        if (N[i] != ',') count++;
    }
    return count;
}

decimal n = Controle(N);
string strN = Convert(n);
Console.WriteLine($"в числе {N} содержиться {Count(strN)} цифр");
