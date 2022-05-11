// Написать программу масштабирования фигуры 
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)" 
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
//В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.Write("Введите коэффициент масштабирования: ");
double k = Convert.ToDouble(Console.ReadLine());


// задаем координаты фигуры
double[] A1 = new double[2] { 0, 0 };
double[] B1 = new double[2] { 2, 0 };
double[] C1 = new double[2] { 2, 2 };
double[] D1 = new double[2] { 0, 2 };

// задаем общий массив
double[][] list = new double[4][] { A1, B1, C1, D1 };

// метод вывода на печать элементов массива
void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != 1 ) Console.Write("; ");
    }
}
// метод масштабирования элементов массива на коэффициент k
double[] Scale(double k, double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * k;
    }
    return arr;
}

Console.WriteLine("Вершины  первоначальной фигуры :");
for (int i = 0; i < list.Length; i++)
{
    Console.Write("(");
    PrintArr(list[i]);
    Console.Write(") ");
}
Console.WriteLine();
Console.WriteLine($"Kоэффициент масштабирования {k}");

for (int i = 1; i < list.Length; i++)
{
    Scale(k, list[i]);
}

Console.WriteLine("Вершины  масштабированной фигуры :");

for (int i = 0; i < list.Length; i++)
{
    Console.Write("(");
    PrintArr(list[i]);
    Console.Write(") ");
}
