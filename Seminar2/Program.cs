// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while ((n<100) || (n>=1000))
// {
//     Console.Write("Вы ошиблись!\nВведите трёхзначное число n: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// int result = (n / 10) % 10;
// Console.WriteLine($"{n} -> {result} ");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int d = n;
// if (n < 100)
//     Console.WriteLine($"{n} -> третьей цифры нет ");
// else
// {
//     while (n > 999)
//     {
//         n = n / 10;
//     }
//     int result = n % 10;
//     Console.WriteLine($"{d} -> {result} ");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру, обозначающую день недели: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while ((n < 1) || (n >= 8))
// {
//     Console.Write("Вы ошиблись!\nВведите цифру, обозначающую день недели: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n < 6)
//     Console.WriteLine($"{n} -> нет ");
// else
//     Console.WriteLine($"{n} -> да ");

