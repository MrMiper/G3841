// Напишите программу, которая принимает на вход число N и выводит произведение чисел от 1 до N
using System.Numerics;
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

BigInteger CalcFact(double num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res*i;
    }
    return res;
}

int number = ReadData("Введите число: ");

BigInteger fact = CalcFact(number);
PrintData("Факториал равен ",fact);