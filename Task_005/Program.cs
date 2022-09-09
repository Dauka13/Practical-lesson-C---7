// Написать программу, которая в двумерном массиве заменяет строки на столбцы 

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

void ReplaceMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("");
    }
}

Console.Clear();
int rows = 5;
int columns = 5;
int min = 10;
int max = 100;

int[,] matrix = GetMatrix(rows, columns, min, max);
PrintMatrix(matrix);
Console.WriteLine("            ");
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    ReplaceMatrix(matrix);
    PrintMatrix(matrix);
}