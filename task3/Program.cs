



Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = Generate2DArray(m, n); 
Print2DArray(arr);
AverageColumn(arr);


void AverageColumn(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            result = result + arr[j, i];
        }
        result = result / m;
        Console.Write(result + " ");
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
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