// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

int ROWS = Random.Shared.Next(1, 10);
int COLUMNS = Random.Shared.Next(1,10);

double[,] RandomArray(int rows, int columns)
{
    double[,]array = new double[rows, columns];
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            array[i,j] = Random.Shared.Next(-15,15) + Random.Shared.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:F2}\t");
        }
        Console.WriteLine();
    }
}

double[,] RndArray = RandomArray(ROWS, COLUMNS);

Console.WriteLine();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Задайте номер строки в массиве: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте номер столбца в массиве: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------------------------------------------------------------------------------");

if (rowNumber < RndArray.GetLength(0) && columnNumber < RndArray.GetLength(1))
{
    Console.WriteLine($"В массиве по заданному вами адресу, строка {rowNumber}, столбец {columnNumber}, находится число {RndArray[rowNumber,columnNumber]:F2}");
}
else
{
Console.WriteLine($"В имеющемся массиве нет элемента с таким адресом");
}
Console.WriteLine("--------------------------------------------------------------------------------------------");
Console.WriteLine("Исследуемый массив: ");
PrintArray(RndArray);
Console.WriteLine("----------------------------------------------");
Console.WriteLine();