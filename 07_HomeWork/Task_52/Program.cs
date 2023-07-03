// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

// void PrintSingleArray(int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//     Console.Write($"{array[i]}\t");
//     }
//     Console.WriteLine();
// }

void PrintSingleArrayDouble(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write($"{array[i]:F2}\t");
    }
    Console.WriteLine();
}

int[,] Array = new int[4,4];
for(int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i,j] = Random.Shared.Next(0,10);
    }
}

int Rower(int rowNumber)
{
    int rowCount = Array.GetLength(1);
    // rowNumber = 0;
    int rowSum = 0;
    for (int i = 0; i < rowCount; i++)
    {
        rowSum = rowSum + Array[i,rowNumber];
    }
    return rowSum;
}

int[] Sum = new int[Array.GetLength(1)];
for (int i=0; i<Array.GetLength(1); i++)
{
    Sum[i] = Rower(i);
}

double[] Average = new double[Sum.GetLength(0)];
for (int i = 0; i < Sum.GetLength(0); i++)
{
    Average[i] = Convert.ToDouble(Sum[i]) / Array.GetLength(1);
}

Console.WriteLine();
Console.WriteLine("-------------------------------");
Console.WriteLine("Исследуемый массив: ");
Console.WriteLine("-------------------------------");
PrintDoubleArray(Array);
Console.WriteLine("-------------------------------");
//PrintSingleArray(Sum);
Console.WriteLine("Среднее значение по столбцам:");
Console.WriteLine("-------------------------------");
PrintSingleArrayDouble(Average);
Console.WriteLine("-------------------------------");
Console.WriteLine();