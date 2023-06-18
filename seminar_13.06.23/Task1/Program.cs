/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber(string text)
{
System.Console.Write(text);
var value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int number = GetNumber("Введите трехзначное число ");
if (number <100 || number >=1000)
{
    System.Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
    return;
}
System.Console.WriteLine($"Вы ввели число {number}");
int secondDigit = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра это {secondDigit}");
