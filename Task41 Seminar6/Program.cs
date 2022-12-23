// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count = 0;
int[] array;
array = new int[10000];
Console.WriteLine("Введите числа массива");
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());

    if (array[i] > 0)
    {
        while (Console.ReadLine() != "stop")
        {
            count++;
        }
        break;
    }

    // else if (array[i] == "stop")
    // {
    //     Console.WriteLine($"Чисел больше нуля: {count}");
    // }
}
Console.WriteLine($"Чисел больше нуля: {count}");