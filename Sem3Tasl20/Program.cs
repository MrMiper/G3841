﻿int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Выводим результат пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

double CalcLen(int x1, int x2, int y1, int y2)
{
    // Вычисляем расстояние между точками в 2D пронстранстве
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}
// Вводим координаты точек
int coordX1 = ReadData("Введите координату X1");
int coordX2 = ReadData("Введите координату X2");
int coordY1 = ReadData("Введите координату Y1");
int coordY2 = ReadData("Введите координату Y2");

// Вычисляем длину
double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

// Выдаем результат
PrintData("Расстояние между точками: ", len);