// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Введите число А:");
int value_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В:");
int value_B = Convert.ToInt32(Console.ReadLine());

int degree(int a, int b)
{

int result = 1;
for (int i = 0; i <= b - 1; i++)
{
    result = result * a;
}
return result;
}

Console.WriteLine($"Результат возведения числа {value_A} в степень {value_B} составит: {degree(value_A, value_B)}");
Console.WriteLine("------------------------------------------------------------");