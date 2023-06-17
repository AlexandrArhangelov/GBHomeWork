/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int GetNumber(string text)
{
System.Console.Write(text);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}
int number = GetNumber("Введите трехзначное число ");
if (number < 100)
{
    Console.WriteLine("Вы ввели число, которое меньше 100, соответственно, оно не содержит третьей по счету цифры");
}
while (number > 1000)
{
    number = number / 10;
}
int result1 = number % 10;
System.Console.WriteLine($"Третья цифра вашего числа это {result1}");
