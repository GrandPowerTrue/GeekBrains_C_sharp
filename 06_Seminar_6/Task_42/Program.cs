// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
string a = "";

while (number != 0 )
{
    i = number % 2;
    number = number / 2;
    a = i + a;
    // Console.WriteLine(a); - проверка работы, вывод всех результатов

}
Console.WriteLine($"Введённое число {number} в двоичной системе выглядит как: {a}");