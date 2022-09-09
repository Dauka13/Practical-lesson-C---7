// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int[,] CreateArray(int rows, int columns, int min, int max)
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

int[] FindNumberPosition(int[,] arr, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 1000 > 0) Console.Write($"{array[i, j]}   ");
            else if (array[i, j] / 100 > 0) Console.Write($" {array[i, j]}   ");
            else if (array[i, j] / 10 > 0) Console.Write($"  {array[i, j]}   ");
            else Console.Write($"   {array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void PrintPosition(int[] pos, int num)
{
    Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0) Console.WriteLine($"Number {num} is in {pos[0]} line, {pos[1]} column");
    else Console.WriteLine($"Number {num} is missing in this array");
    System.Console.WriteLine();
}

int NumberToFind()
{
    Console.WriteLine();
    Console.Write("Enter number:   ");
    string writeNumber = Console.ReadLine();
    int number = int.Parse(writeNumber);
    return number;
}

Console.Clear();
int rows = 5;
int columns = 7;
int min = 1;
int max = 1000;

int[,] array1 = CreateArray(rows, columns, min, max);
PrintArray(array1);
int number = NumberToFind();
int[] position = FindNumberPosition(array1, number);
PrintPosition(position, number);