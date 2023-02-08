// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void TryFindElementInArray(int[,] arr, int m, int n)
{
    if (m - 1 < arr.GetLength(0) && n - 1 < arr.GetLength(1))
    {
        System.Console.WriteLine(arr[m - 1, n - 1]);
    }
    else System.Console.WriteLine("Элемента с заданными индексами нет");
}


int[,] array = Generate2DArray(4, 4);
Print2DArray(array);
System.Console.WriteLine();
TryFindElementInArray(array, 4, 3);
System.Console.WriteLine();
TryFindElementInArray(array, 5, 4);

