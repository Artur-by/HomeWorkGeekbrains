// Найти произведение двух матриц
Console.Write("Введите число строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());


// метод создания массива
int[,] Create(int a, int b)
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 4);
        }
    }
    return arr;
}

//метод вывода элементов массива в консоль
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();
    }
}


// метод умножения элементов из 2х матриц

int Multiplication(int[,] matr1, int[,] matr2, int m, int n)
{
    int sum = 0;
    for (int i = 0; i < matr1.GetLength(1); i++)
    {
        sum = sum + matr1[m, i] * matr2[i, n];
    }
    return sum;

}

int[,] matrix1 = Create(a, b);
int[,] matrix2 = Create(b, d);
int[,] matrix3 = new int[a, d];

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
        matrix3[i, j] = Multiplication(matrix1, matrix2, i, j);
    }
}
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("Матрица итоговая- перемноженная:");
PrintMatrix(matrix3);