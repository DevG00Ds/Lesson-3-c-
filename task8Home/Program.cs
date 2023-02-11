// Напишите программу, которая на входе принмает число N, 
// а на выходе показывает все четные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write( " Введите число: " );
int number = Convert.ToInt32(Console.ReadLine());

int fnumber = 2;

if ( number > 1 )
{
    while ( fnumber <= number)
    {
        Console.Write(fnumber + " ");
        fnumber = fnumber + 2;
    }
}