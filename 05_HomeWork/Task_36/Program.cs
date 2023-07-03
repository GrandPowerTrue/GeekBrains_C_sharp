// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] MetodRandomArray()
{
    int[] array = new int[10];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100,100);
    }
    return array;
}
int[] Array = MetodRandomArray();
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Исследуемый, случайный массив:");
Console.WriteLine(" ");
Console.WriteLine(String.Join(", ", Array));
Console.WriteLine("--------------------------------------------------------------------------");

int summ = 0;
for(int i = 1; i < Array.Length; i = i + 2)
{
    summ = summ + Array[i];
}

Console.WriteLine(" ");
Console.WriteLine($"Cумма элементов, стоящих на нечётных индексах: {summ}");
Console.WriteLine("--------------------------------------------------------------------------");
