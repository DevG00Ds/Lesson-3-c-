// Напишите программу, которая принимает на вход 3 числа 
//и выдает максимальное из этих чисел.

// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22

int max = 0;

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if(numberB > numberС)
{
    max = numberB;
}
else
{
    max = numberС;
}
if(numberС > numberA)
{
    max = numberС;
}
else
{
    max = numberA;
}

Console.WriteLine("max:  " + max);
