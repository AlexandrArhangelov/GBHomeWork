Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1: // Понедельник
        Console.WriteLine("Рабочий день");
        break;
    case 2: // Вторник
        Console.WriteLine("Рабочий день");
        break;
    case 3: //Среда
        Console.WriteLine("Рабочий день");
        break;
    case 4: //Четверг
        Console.WriteLine("Рабочий день");
        break;
    case 5: //Пятница
        Console.WriteLine("Рабочий день");
        break;
    case 6: //Суббота
        Console.WriteLine("Суббота, наконец-то выходной");
        break;
    case 7: //Воскресенье
        Console.WriteLine("Воскресенье, но в понедельник снова на работу");
        break;
        default: 
        Console.WriteLine("Такого дня нет");
        break;
}
