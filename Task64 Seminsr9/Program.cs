// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
PrintNumber(N, count);
Console.Write(1);

void PrintNumber(int N, int count)
{
  if (count > N) return;
  PrintNumber(N, count + 1);
  Console.Write(count + " ");
}