// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("--------------------------");
Console.WriteLine("Ведите число для анализа: ");
int valueOriginal = Convert.ToInt32(Console.ReadLine());
int value = valueOriginal;
int sum = 0;
int count = 0;

for(int i = 0; value > 0; i++)
    {
    sum = sum + value % 10;
    value = value / 10;
    count = i+1;
    }

Console.WriteLine();
Console.WriteLine($"Во введённом числе: {valueOriginal}, содержится цифр: {count}, их сумма равна: {sum}");
Console.WriteLine();