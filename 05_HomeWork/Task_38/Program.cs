// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным
// и минимальным элементов массива. (не использовать стандартные функции/методы)
// [3 7 22 2 78] -> 76

int[] MetodRandomArray()
{
    int[] array = new int [17];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0,100);
    }
    return array;
}

int[] Array = MetodRandomArray();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine("Исследуемый, случайный массив натуральных чисел:");
Console.WriteLine(" ");
Console.WriteLine(String.Join(", ", Array));
Console.WriteLine("-----------------------------------------------------------------");

int minimum = Array[0];
int maximum = 0;

for (int i = 0; i < Array.Length; i++)
{
    if ( Array[i] > maximum )
    {
    maximum = Array[i];
    }
    
    if (minimum > Array[i])
    {
     minimum = Array[i];
    }
}
Console.WriteLine($"Максимальное число из массива {maximum}");
Console.WriteLine();
Console.WriteLine($"Минимальное число из массива {minimum}");

int delta = maximum - minimum;

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {delta}");
Console.WriteLine("-----------------------------------------------------------------");