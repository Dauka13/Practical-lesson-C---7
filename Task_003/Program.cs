// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] ReplaceRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int value = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = value;
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int rows = 5;
int columns = 5;
int min = 1;
int max = 10;

int[,] matrix = GetMatrix(rows, columns, min, max);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix2 = ReplaceRow(matrix);
PrintMatrix(matrix2);