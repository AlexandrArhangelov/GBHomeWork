/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Print(string message){

    Console.Write(message);
    int readInput = Convert.ToInt32(Console.ReadLine());
    int result = readInput;
    return result;
}

int Power(int powerBase, int exponent){

    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

int powerBase = Print("Введите значение: ");
int exponent = Print("Введите экспонент: ");
Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
