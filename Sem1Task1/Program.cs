// Задача №1
// Напишите прогрмму, которая на вход принимает
// два числа и проверяет, является ли первое число
//  квадратом второго.

// Считываем данные с консоли первое число
Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли второе число
Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputNum1!=null && inputNum2!=null)

{
    // // Парсим введенное числоо
    int number1 = int.Parse(inputNum1); 
    // // Парсим введенное числоо
    int number2 = int.Parse(inputNum2);

    if (number1==number2*number2)
    {
        Console.WriteLine("Первое число квадрат второго!");
    }
        else
    {
            Console.WriteLine("Первое число не квадрат второго!");
    }
    
}