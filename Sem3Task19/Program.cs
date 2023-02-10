﻿// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// Делаем присвоеие числа и его длину
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
// Если длина равна 5
if (len == 5)
{
    // Если первая цифра и последняя, так же вторая и четвертая совпадают, то число палиндром
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        // Иначе не палиндром
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{

    // Если длина не равна 5, то это не пятизначное число
    Console.WriteLine($"Число: {number} - не является пятизначным");
}