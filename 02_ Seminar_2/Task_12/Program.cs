// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine(" ");
Console.WriteLine("Введите число1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int b = Convert.ToInt32(Console.ReadLine());
int prov = b % a;

if (prov != 0)
{
    Console.WriteLine ();
}
{
    Console.WriteLine ();
}



// Console.WriteLine(" ");
// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b)
// {
//     Console.WriteLine("Введённые числа равны");
// }
// else
// {
//     if (a > b)
//     {
//         Console.WriteLine(" ");
//         Console.WriteLine("Большее число {0} Меньшее число {1}", a, b);
//         Console.WriteLine(" ");
//     }
//     else
//     {
//         Console.WriteLine(" ");
//         Console.WriteLine("Большее число {0} Меньшее число {1}", b, a);
//         Console.WriteLine(" ");
//     }
// }