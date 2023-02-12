// Напишите программу, которая принимает на вход координаты точки (X, Y),
// Причём X Не равна 0 и Y не равна 0 и выдает номер четверти плоскости, в которой находится эта точка.

int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");
PrintQuterTest();


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");

}

// Метод определяет четверть по коориднатам точки
void PrintQuterTest()
{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}