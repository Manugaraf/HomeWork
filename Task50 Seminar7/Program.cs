// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange);
        }
    }

    return matr;
}
int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
    Console.WriteLine();
    if (rows < matr.GetLength(0) && colums < matr.GetLength(1))
    {
        Console.WriteLine(matr[rows, colums]);
    }
    else
    {
        Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
    }
}

int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);