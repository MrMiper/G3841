// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Считываем данные с консоли первое число
Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли второе число
Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if (inputNum1!=null && inputNum2!=null)
{
    // // Парсим введенное число
    int number1 = int.Parse(inputNum1); 
    // // Парсим введенное число
    int number2 = int.Parse(inputNum2);
if (number1 < number2)
{
Console.WriteLine("Первое число меньшее, а второе большее");
}
else {
Console.WriteLine("Второе число меньшее, а второе большее");
     }
}