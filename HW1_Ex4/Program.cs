﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число:");
int numberD = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB & numberA > numberD)
    {
        Console.WriteLine($" Максимальное число {numberA}") ;
    }
else if (numberB > numberA & numberB > numberD)
    {
        Console.WriteLine($" Максимальное число {numberB}") ;
    }
else 
    {
        Console.WriteLine($" Максимальное число {numberD}") ;
    }