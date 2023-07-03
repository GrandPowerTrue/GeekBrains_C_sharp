void PrintSingleArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
void PrintDualArray(int[,] array)
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

int[,] Array = new int[3,3];
for(int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        {
        Array[i,j] = Random.Shared.Next(0,10);
        }
    }
}
Console.WriteLine();
Console.WriteLine("Исследуемый массив: ");
PrintDualArray(Array);
Console.WriteLine();


int[] Sum = new int[Array.GetLength(1)];
//int summe = Array[0,0] + Array[1,0];
int summa = 0;
//int count = 0;
for (int i = 0; i < Array.GetLength(1); i++)
{
    //summa = summa + Array[i,i-i];
    summa = summa + Array[i,i];
    Sum[i] = summa;
    //count = 
}
Console.WriteLine("--------------------------");
Console.WriteLine(summa);
PrintSingleArray(Sum);