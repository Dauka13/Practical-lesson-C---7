// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) Console.Write($" {array[i, j]}  ");
            else Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[] GetAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.WriteLine("                      ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

Console.Clear();
int rows = 5;
int columns = 5;
int min = 1;
int max = 10;

int[,] matrix = GetMatrix(rows, columns, min, max);
PrintMatrix(matrix);
double[] average = GetAverage(matrix);
PrintArray(average);
Console.WriteLine();