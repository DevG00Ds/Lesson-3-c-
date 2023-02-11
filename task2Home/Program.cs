//Напишите программу, которая на вход принимает два числа и выдает, 
//какое число более, а какое мешьше.
// a = 5, b = 7 -> min = 5, max = 7
// a = 2, b = 10 -> min = 2, max = 10
// a = -9, b = -3 -> min = -9, max = -3


Console.WriteLine("Введите число № 1");
string answer1 = Console.ReadLine();
Console.WriteLine("Введите число № 2");
string answer2 = Console.ReadLine();

int max = 0;
int min = 0;
int numberA = Convert.ToInt32(answer1);
int numberB = Convert.ToInt32(answer2);

if ( numberA > numberB )
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}


Console.WriteLine(" max = " + max + " и " + " min = " + min);