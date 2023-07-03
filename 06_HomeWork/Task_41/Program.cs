// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintSingleArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Обозначьте количество анализируемых чисел m (размер массива): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------");

int[] Array = new int[m];
Console.WriteLine($"Введите {m} чисел для заполнения массива: ");
for (int i = 0; i < m; i++)
{
Array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine($"Имеем массив из {m} чисел для исследования: ");
Console.WriteLine("-------------------------------------------------------------");
PrintSingleArray(Array);
Console.WriteLine("-------------------------------------------------------------");

int count = 0;
for (int i = 0; i < m; i++)
{
    if (Array[i] > 0)
    {
        count = count + 1;
    }
}

if (count > 0)
    {
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine($"Введено чисел больше нуля {count}");
    Console.WriteLine("-------------------------------------------------------------");
    }
    else
        {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("В массиве нет чисел больше нуля");
        Console.WriteLine("-------------------------------------------------------------"); 
        }