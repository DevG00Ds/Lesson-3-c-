// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Введите номер дня");
string daynumber = Console.ReadLine();
if (daynumber == "1")
{
    Console.WriteLine("Понедельник");
}
else if (daynumber == "2")
{
   Console.WriteLine("Вторник");
}
else if (daynumber == "3")
{
    Console.WriteLine("Среда");
}
else if (daynumber == "4")
{
    Console.WriteLine("Четверг");
}
else if (daynumber == "5")
{
    Console.WriteLine("Пятница");
}
else if (daynumber == "6")
{
    Console.WriteLine("Суббота");
}
else if (daynumber == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня");
}