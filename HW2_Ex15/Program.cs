// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Message(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Message("Введите день недели:");
string week = "Это не день недели";

string check(int number)
{
    if (number >= 6 && number < 8) week = "Да";
    if (number >= 1 && number < 6) week = "Нет";
    return week;
}

Console.WriteLine(check(number));