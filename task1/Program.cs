﻿//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine( "ВВедите число №1" );
string answer1 = Console.ReadLine();
Console.WriteLine( "Введите число №2" );
string answer2 = Console.ReadLine();
int numberA = Convert.ToInt32(answer1);
int numberB = Convert.ToInt32(answer2);

if (numberA == numberB * numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}