﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число:");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1 ;

while (number <= N)
    {
        if (number % 2 == 0)
        {         
           Console.Write($"{number}  ");                   
        }
        number++;
    }

// Можете показать способ как еще можно выводить данные? Хотел, чтобы через запятую данные выводило, 
// но тогда после последнего значение тоже ставится запятая, пришлось просто через отступ
