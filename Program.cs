﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным (без остатка %)
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число => ");
int number = Convert.ToInt32(Console.ReadLine());     

if (number % 2 == 0)
{
       Console.WriteLine("да");                // Вывод в консоль
}
else
{
    Console.WriteLine("нет");                  // Вывод в консоль
}