// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
//     Console.WriteLine($"a={a}; b={b} -> max {a} ");
// else
//     Console.WriteLine($"a={a}; b={b} -> max {b} ");

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите число n1: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n2: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n3: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// if ((n1 > n2) & (n1 > n3))
//     Console.WriteLine($"{n1}, {n2}, {n3} -> {n1} ");
// else if (n2 > n3)
//     Console.WriteLine($"{n1}, {n2}, {n3} -> {n2} ");
// else 
//     Console.WriteLine($"{n1}, {n2}, {n3} -> {n3} ");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n % 2 == 0)
//     Console.WriteLine($"{n} -> да ");
// else
//     Console.WriteLine($"{n} -> нет ");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число N от 1: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string s = "";

// while (n < 1)
// {
//     Console.Write("Вы ошиблись!\nВведите число N от 1: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 1; i <= n; i++)
// {
//     if (i % 2 == 0) 
//         s = s + ($"{i } ");
// }

// Console.WriteLine($"{n} -> {s} ");
