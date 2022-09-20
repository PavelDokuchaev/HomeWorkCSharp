Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());;

if(number1 == number2)
    {
        Console.WriteLine("Вы ввели два одинаковых числа");
    }
else
    {
        if(number1 > number2)
        {
        Console.WriteLine($"Большее число: {number1}");
        Console.WriteLine($"Меньшее число: {number2}");
        }   
        else
        {
        Console.WriteLine($"Большее число: {number2}");
        Console.WriteLine($"Меньшее число: {number1}");
        }
    }