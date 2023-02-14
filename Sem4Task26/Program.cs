// Напишите программу, которая на вхож принимает число и выдает количество цифр в числе
// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}


int SumDigit(int num)
{
    int res1 = 0;
    while(num > 0)
    {
        res1++;
        num = num/10;
    }
    return res1;
}

int SumDigitStr(int num)
{
    int res2 = 0;
    res2 = num.ToString().Length;
    return res2;
}
int number = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("Вариант (SumDigit)",res1);
DateTime d2 = DateTime.Now;
int res2 = SumDigitStr(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("Вариант (SumDigit)",res2);
