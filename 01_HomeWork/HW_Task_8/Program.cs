// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Помогает ;) https://metanit.com/sharp/tutorial/2.6.php

Console.WriteLine(" ");
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--------------");

if (n >= 4)
{
    for (int a = 2; a <= n; a = a + 2)
    {
            Console.WriteLine(a);
    }
    Console.WriteLine("--------------");
}
else
{
    // Недостало свободного времени, чтобы проработать вариант с чётными отрицательными числами. 
    Console.WriteLine($"!!! Введённое вами число не позволяет сформировать интервал чётных положительных ;) чисел в диапазоне от 1 до {n} !!!");
    Console.WriteLine("--------------");
}