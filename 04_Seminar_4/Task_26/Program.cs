// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int func(int number)
{
int digits = 1; // кол-во цифр
    while (number >= 10)
    {
    digits++;
    number = number/10;
    }
    return digits;
}

int number = ReadInt();
int digits1 = func(number);
Console.WriteLine($"Введённое число {number} состоит из {digits1} цифр");
