// программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

int[] array = { -100, -10, -7, -5, -3, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15 };

void Days(int days)
{
    if (days > 0 && days < 8)
    {
        if (days < 6)
        {
            Console.WriteLine("Нет");
        }
        else
        {
            Console.WriteLine("Да ");
        }
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует!");
    }
}

int len = array.Length;
int count = 0;
while (count < len)
{
    Days(array[count]);
    count++;
}

