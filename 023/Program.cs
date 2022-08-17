// Программа которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine()!);
int index = 1;

while(x >= index)
{
   var result = Math.Pow(index, 3);
   index++;
   Console.Write(result + "  ");
}