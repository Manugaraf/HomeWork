// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int Line(int N)
{
    int a = 1;
    if (N <= 0) return -1;
    if (N == 1) return 1;
    Console.WriteLine(Line(N - 1));
    return N;
}
Console.Write(Line(N));