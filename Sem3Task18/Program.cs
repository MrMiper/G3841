int qNum = ReadData("Введите номер четверти");

PrintQuterTest();


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");

}

// Метод определяет допустимого диапазона координат точек по четверти
void PrintQuterTest()
{
    if (qNum > 0 && qNum< 5)
    {
    if (qNum == 1) Console.WriteLine("x > 0, y > 0");
    if (qNum == 2) Console.WriteLine("x > 0, y < 0");
    if (qNum == 3) Console.WriteLine("x < 0, y < 0");
    if (qNum == 4) Console.WriteLine("x < 0, y > 0");
    }
    else Console.WriteLine("Это не номер четверти");
    
}
