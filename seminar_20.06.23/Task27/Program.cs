/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Print(string message){

    Console.Write(message);
    int readInput = Convert.ToInt32(Console.ReadLine());
    int result = readInput;
    return result;
}
int SumDigit(int number){
    int result = 0;
    while (number > 0){
        result += number % 10;
        number = number / 10;
        }
    return result;
}
int number = Print("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {number} равна {SumDigit(number)}");
