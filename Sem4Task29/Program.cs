﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[] Gen1DArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
int arrLen = ReadData("Введите длину массива");
Console.WriteLine("Введите минимальное число массива");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите максимальное число массива");
int b = int.Parse(Console.ReadLine()??"0");

int[] arr = Gen1DArr(arrLen, a, b+1);
Print1DArr(arr);