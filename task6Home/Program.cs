// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write( " Введите число: ");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int DIV = number % 2;

if ( DIV ==  0 )
{
    Console.WriteLine( " Да " );
}
else
{
    Console.WriteLine( " Нет " );
}
