// Программа принимает на вход число и выдаёт сумму цифр в числе


// метод преобразования отрицательного числа в положительное
double Controle(double N)
{
    if (N < 0) return -N;
    else return N;
}

// метод преобразования числа в строку
string ConvertN(double N)
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


Console.Write("Введите число, для дробного числа используйте запятую: ");
string s = Console.ReadLine();
double N = Convert.ToDouble(s);

double n = Controle(N);
string strN = ConvertN(n);
Console.WriteLine($"в числе {N} сумма цифр {Sum(strN)}");

