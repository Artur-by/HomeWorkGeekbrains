// Найти сумму чисел от 1 до А
Console.Write("Введите целое положительное число А: ");
string s = Console.ReadLine();
double A = Convert.ToDouble(s);

double result = A * (A + 1) / 2;
System.Console.WriteLine($"Сумма чисел от 1 до {A} равна {result}");
