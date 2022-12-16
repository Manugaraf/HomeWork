// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] array;
array = new int[8];
Console.WriteLine("Введите числа массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}