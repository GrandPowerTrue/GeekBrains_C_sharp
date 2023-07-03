// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a+b)>c && (b+c)>a && (a+c)>b)
{
    Console.WriteLine("Такой треугольник может существовать");
}
    else
    {
            Console.WriteLine("Такой треугольник не может существовать");
    }
