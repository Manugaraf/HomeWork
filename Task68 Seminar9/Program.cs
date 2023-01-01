// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int Function = Akkerman(M, N);
Console.Write($"Функция Аккермана равна {Function} ");

int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0) return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}
