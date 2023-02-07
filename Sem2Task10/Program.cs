// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Random numSintezator = new System.Random();
int num = numSintezator.Next(100, 1000);
Console.WriteLine(num);
int res = num/10;
int digit1 = res%10;
Console.WriteLine(digit1);