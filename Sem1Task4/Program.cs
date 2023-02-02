// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Считываем данные с консоли первое число
Console.WriteLine("Введите первое число");
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли второе число
Console.WriteLine("Введите второе число");
string? inputNum2 = Console.ReadLine();
//Считываем данные с консоли третье число
Console.WriteLine("Введите третье число");
string? inputNum3 = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if(inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    // Парсим введенные числа
int inputNumA = int.Parse(inputNum1);
int inputNumB = int.Parse(inputNum2);
int inputNumC = int.Parse(inputNum3);
// Уточяем, больше ли первое число второго
if (inputNumA > inputNumB)
{
    // Так же уточняем является ли первое число больше третьего
    if (inputNumA > inputNumC)
    {
        Console.WriteLine("Максимальное число " + inputNumA);
    }
        else 
        {
             Console.WriteLine("Максимальное число " + inputNumC);
        }
    }
// Если второе число оказывается больше первого, то сравниваем его с третим
else if (inputNumB > inputNumC)
{
Console.WriteLine("Максимальное число " + inputNumB);
}
// Если третье число оказалось больше второго, то значит оно и больше первого, выводим на консоль
else {
Console.WriteLine("Максимальное число " + inputNumC);
}
}