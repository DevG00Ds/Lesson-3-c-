// Напишите программу, которая принимает на вход 3 числа 
//и выдает максимальное из этих чисел.

Console.WriteLine("Введите первое число");
string numberA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string numberB = Console.ReadLine();
Console.WriteLine("Введите третье число");
string numberC = Console.ReadLine();

int MAX = 0;
int a = Convert.ToInt32(numberA);
int b = Convert.ToInt32(numberB);
int c = Convert.ToInt32(numberC);


if (a > MAX)
{
    MAX = a;
}
else if (b > MAX)
{
    MAX = b;
}
else if (c > MAX)
{
    MAX = c;
}
else
{
    Console.WriteLine(" MAX = 0 " + MAX);
}