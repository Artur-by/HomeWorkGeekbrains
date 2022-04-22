// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

int Ax = 7;
int Ay = -5;
int Bx = 1;
int By = -1;

int len = Ax - Bx;
int wid = Ay - By;

double Square(int len, int wid)
{
    return Math.Sqrt(len * len + wid * wid);

}
double S = Square(len, wid);
Console.Write(Math.Round(S, 2));
