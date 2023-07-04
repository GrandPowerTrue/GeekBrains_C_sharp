// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



// Console.WriteLine();
// Console.WriteLine("-------------------------------------------------------------");
// Console.WriteLine("Обозначьте количество анализируемых чисел m (размер массива): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("-------------------------------------------------------------");

int[] Array = new int[8];

for (int i = 0; i < 8; i++)
{
Array[i] = Random.Shared.Next(0, 100);
}

void PrintSingleArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
PrintSingleArray(Array);
Console.WriteLine();