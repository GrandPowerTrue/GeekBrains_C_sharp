// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] MetodRandomArray()
{
    int[] array = new int[17];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 1000);
    }
    
    return array;
}
int[] Array = MetodRandomArray();

Console.WriteLine("------------------------------------------------------------------------------------");
Console.WriteLine("Исследуемый, случайный массив:");
Console.WriteLine(" ");
Console.WriteLine(String.Join(", ", Array));
Console.WriteLine("------------------------------------------------------------------------------------");

int count = 0; // задаём переменную для счётчика положительных чисел массива
for (int i = 0; i < Array.Length; i++)
{
    if ( Array[i] % 2 == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {count}");
Console.WriteLine("------------------------------------------------------------------------------------");