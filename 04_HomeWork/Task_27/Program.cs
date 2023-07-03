// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    Console.WriteLine("--------------------------");
    Console.WriteLine("Ведите число для анализа: ");
    int value = Convert.ToInt32(Console.ReadLine());

int NuberOfChar()
{
    int number = value;
    int digits = 1;
    while (number >= 10)
    {
    number = number/10;
    digits = digits++;
    }
    return digits;
}


int S = 0;  
int i = NuberOfChar();
while(i > 0)
{
    S = value / 10 + S;
    i = i-1;
}
//    return SOD;
//}

//int SumOfDigitsFinal = SumOfDigits();
//Console.WriteLine($"Сумма цифр в числе {value} составляет {SOD}");
Console.WriteLine(S);