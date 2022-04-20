// программf, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет


// Функция Count() подсчитывает на какое число необходимо разделить
// введенное число чтобы осталось только три знака

int Count(int number)
{
    int count = 1000;
    while (number - count > 0)
    {
        count = count * 10;
    }
    count = count / 1000;
    return count;
}

int NumA = -992365897;
if (NumA < 0) NumA = -NumA;

if (NumA < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    int count = Count(NumA);
    Console.WriteLine((NumA / count) % 10);
}



