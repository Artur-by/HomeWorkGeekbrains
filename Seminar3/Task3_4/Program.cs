
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом - например 12521.

string Compare(int N)
{
    int num1 = N / 10000;
    int num2 = (N / 1000) % 10;
    int num4 = (N % 100) / 10;
    int num5 = N % 10;
    string result;

    if (num1 == num5 && num2 == num4) result = "Да";
    else result = "Нет";
    return result;

}

int N = 42324;
Console.Write(Compare(N));