// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int temp = a;
int remainder, revNumber = 0;
while (a > 0)
{
    remainder = a % 10;
    a = a / 10;
    revNumber = (revNumber * 10) + remainder;
}
if (temp == revNumber)
{
    Console.WriteLine("Это число палиндром");
}
else
{
    Console.WriteLine("НЕ палиндром");
}