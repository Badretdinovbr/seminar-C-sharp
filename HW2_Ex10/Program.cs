// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int temp = number / 10;
int SecondDigit = temp % 10;

Console.WriteLine(SecondDigit);
