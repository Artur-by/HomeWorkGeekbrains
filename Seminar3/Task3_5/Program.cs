// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

int Ax = 7;
int Ay = -5;
int Az = 0;
int Bx = 1;
int By = -1;
int Bz = 9;

int len = Ax - Bx;
int wid = Ay - By;
int lon = Az - Bz;

double Square(int len, int wid, int lon)
{
    return Math.Sqrt(len * len + wid * wid + lon * lon);

}
double S = Square(len, wid, lon);
Console.Write(Math.Round(S, 2));

