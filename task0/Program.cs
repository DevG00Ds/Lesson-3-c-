// Напишите программу которая на вход принимает число и выдает его квадрат ( число умноженное на само себя )

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine( "Введите число" );
string userAnswer = Console.ReadLine();
int userNumber = Convert.ToInt32(userAnswer);

Console.WriteLine(userNumber * userNumber);
