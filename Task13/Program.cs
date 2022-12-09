// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x;
while (num > 99)
{
    if (num >=100)
    {
        num = num / 10;
        x = num % 10;
        Console.WriteLine(x);
    }
    else
    {
        Console.WriteLine("Нет третьей цифры");
    }
}


