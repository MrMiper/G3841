//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Считываем данные с консоли первое число
Console.WriteLine("Введите число");
string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputNum!=null)
{
// Парсим введенное число
    int number = int.Parse(inputNum);
    string resoult = String.Empty;
 for (int i = 2; i < number+1; i = i+2)
 {
    if (i %2 == 0)
    {
        Console.WriteLine (i + " ");
    }
 }

}
