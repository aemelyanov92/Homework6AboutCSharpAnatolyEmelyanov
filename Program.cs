﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.// 
// Console.Write("Введите числа: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1,
//  y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());


// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// Console.WriteLine($"Пересечение в точке: ({x};{y})");

// Доп. задачка:
// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Если приводить к строке, то всё нормально
// Console.Write("Введите десятичное число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string Number2 = Convert.ToString(Number,2);
// Console.WriteLine(Number2);


// А таким способом незадача... Выдаёт правильно все числа, кроме 2ки

// Console.Write ("Введите десятичное число ");
// int Num10 = Convert.ToInt32(Console.ReadLine());
// int Num2 = 0;
// int i = 0;

// int[] b = new int[10];

// while (Num10 > 0)
// {
//     Num2 = Num10 % 2;
//     b[i] = Num2;
//     i++;

//     Num10 = Num10 / 2;

//     Console.Write(Num2);
// };