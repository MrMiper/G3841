// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

int result = (int)Math.Pow(num1, num2);

Console.WriteLine($"{num1} в степени {num2} = {result}");
