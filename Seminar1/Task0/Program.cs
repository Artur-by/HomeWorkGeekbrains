// Задача 
// В зависимости ои введенной цифры вывести день недели.
// Предполагаем, что введенные цифры целые

int N = 7;
if (N <= 0) Console.WriteLine(" Такого дня недели не существует");
if (N > 7) Console.WriteLine(" Такого дня недели не существует");
if (N == 1) Console.WriteLine("Понедельник");
if (N == 2) Console.WriteLine("Вторник");
if (N == 3) Console.WriteLine("Среда");
if (N == 4) Console.WriteLine("Четверг");
if (N == 5) Console.WriteLine("Пятница");
if (N == 6) Console.WriteLine("Суббота");
if (N == 7) Console.WriteLine("Воскресенье");
