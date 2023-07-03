// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Введите значение углового коэффициента k1 для первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение пересечения первой прямой b1 с осью y: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите значение углового коэффициента k2 для второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение пересечения второй прямой b2 с осью y: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------");

if (k1 == k2)
{
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("Прямые параллельны и не могут пересекаться");
    Console.WriteLine("-------------------------------------------------------------");
}
    else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * ((b2 - b1)/(k1 - k2)) + b1;
            Console.WriteLine();
            Console.WriteLine($"Координаты точки пересечения прямых ({x:F2} ; {y:F2})");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
        }
