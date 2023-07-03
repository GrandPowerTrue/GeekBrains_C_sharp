// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> нет

// int[] GetRandomArray()
// {
//     int[] array = new int[5];

//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(-100, 100);
//     }
    
//     return array;
// }
// int[] masterArray = GetRandomArray();
// Console.WriteLine("Введите искомое число ");

// int numberFind = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine($"Начальный массив\t[ {string.Join(", ", masterArray)} ]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (numberFind == masterArray[i])
//     {
//         int indicator = 1;
//     }
//     else
//     {
//         int indicator = 2; 
//     }
// }

// if (indicator = 1); Console.WriteLine("Да");
// if (indicator = 1); Console.WriteLine("Нет");

int [] GetRandomArray()
{
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] array = GetRandomArray();
int count = 0;
Console.WriteLine("Vvedi chislo");
int numberFind = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < array.Length; i++)
{
    if(numberFind == array[i])
    {
        count++;
        break;
    }
}
 if (count == 1)
 {
    Console.WriteLine("True");
 }
else{
    Console.WriteLine("false");
}