﻿//Напишите программу, которая на вход принимает два числа и выдает, 
//какое число более, а какое мешьше.


Console.WriteLine("Введите число № 1");
string answer1 = Console.ReadLine();
Console.WriteLine("Введите число № 2");
string answer2 = Console.ReadLine();

int numberA = Convert.ToInt32(answer1);
int numberB = Convert.ToInt32(answer2);

if ( numberA > numberB )
{
    Console.WriteLine("Первое число MAX");
    Console.WriteLine("Второе число MIN");
}
else if (numberA < numberB)
{
    Console.WriteLine("Первое число MIN");
    Console.WriteLine("Второе число MAX");
}
else
{
    Console.WriteLine("Оба числа равны");
}