// Написать программу преобразования десятичного числа в двоичное
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());


// метод перевода десятичного в двоичное число
int[] Binary(int num)
{
    // предполагаем что введенное число положительное и соотвествует int = 4 байта или 32 разряда
    int[] bin = new int[32];
    int i = 31;
    int integer = num;
    // цикл деления введенного числа на 2 и записи в массив остатка в конец массива
    while (integer != 0)
    {
        int rest = integer % 2;
        integer = integer / 2;
        bin[i] = rest;
        i--;
    }
    return bin;
}

// метод вывода двичного числа в консоль
void Print(int[] list)
{
    // так как массив из 32 разрядов циклом while отсеиваем незначащие нули
    int i = 0;
    while (list[i] == 0) i++;
    for (int j = i; j < list.Length; j++)
    {
        Console.Write(list[j]);
    }
}

int[] list = Binary(num);
System.Console.WriteLine($"Число {num} в двоичном представлении:");
Print(list);


