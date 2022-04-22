// программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Quart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0)
    {
        return 3;
    }
    else
    {
        return 4;
    }
}

int x = -15;
int y = 10;
Console.Write(Quart(x, y));
