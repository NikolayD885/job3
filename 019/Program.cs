// Программа которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");

string array = Console.ReadLine()!;

var n = array.Length;

if ( n != 5 )

Console.WriteLine("Ошибка, введите пятизначное число");

else if (array[0] == array[4] && array[1] == array[3])

Console.WriteLine("Число палиндром");
else
{
Console.WriteLine("Число не палиндром");
}