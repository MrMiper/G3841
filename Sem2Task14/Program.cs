﻿// // Напиши программу, которое принимает число и выводит кратное ли число 7 и 23
// Присваиваем число
int num = int.Parse(Console.ReadLine()??"0");
// Проверяем делится ли число на 7
int res1 = num%7;
// Проверяем делится ли число на 23
int res2 = num%23;
// Если число делится и на 7 и на 23, то выводим, что число кратное этим числам
if ((res1 == 0) && (res2 == 0))
{

    Console.WriteLine("Кратное");
}
else
{
    // Если не остаток остается хоть в 1 случае, то число не кратно
    Console.WriteLine("Некратно ");
}