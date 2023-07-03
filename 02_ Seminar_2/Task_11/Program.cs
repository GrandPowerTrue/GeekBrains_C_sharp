// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int midDigit = (number / 100) % 10;
Console.WriteLine(midDigit);

int lastDigit = (number % 10);
Console.WriteLine(lastDigit);

int iskomoe = midDigit * 10 + lastDigit;
Console.WriteLine(iskomoe);






