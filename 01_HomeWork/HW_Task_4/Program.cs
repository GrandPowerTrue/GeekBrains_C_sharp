// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine(" ");
Console.Write("Введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n1 == n2 && n2 ==n3)
{
Console.WriteLine(" ");
Console.WriteLine("Введённые числа равны");
Console.WriteLine(" ");
}
else
{
if (n2 > max) max = n2;
if (n3 > max) max = n3;
Console.WriteLine(" ");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine(" ");
}