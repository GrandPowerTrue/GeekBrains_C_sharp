// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray()
{
    int[] array = new int[4];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100, 100);
    }
    
    return array;
}
int[] masterArray = GetRandomArray();
Console.WriteLine($"Начальный массив\t[ {string.Join(", ", masterArray)} ]"); // \t - символ табуляции, для выравнивания начала строк при выводе

for(int i = 0; i < masterArray.Length; i++)
    {
        masterArray[i] = - masterArray [i];
    }
Console.WriteLine($"Инвертированный массив\t[ {string.Join(", ", masterArray)} ]");