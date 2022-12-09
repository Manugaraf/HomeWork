Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i;
for (i = 99; num >= 100; i++)
{
    if (num > 99)
    {
        num = num / 10;
        i = num % 10;
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine("Нет третьей цифры");
    }
}