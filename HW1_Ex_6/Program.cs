﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите первое целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number % 2;
if (number % 2 == 0)
    {
        Console.WriteLine($" Число {number} делится без остатка") ;
    }
else
    {
        Console.WriteLine($" Число {number} не делится без остатка, остаток {remainder}") ;
    }