﻿// Напишите программу, которая принимает на вход 3 числа 
//и выдает максимальное из этих чисел.

// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22

int max = 0;

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());

if(numberA > max)
{
    max = numberA;
}
if(numberB > max)
{
    max = numberB;
}
if(numberС > max)
{
    max = numberС;
}

Console.WriteLine("max " + max);
