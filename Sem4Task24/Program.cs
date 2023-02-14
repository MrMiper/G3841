// Напишите программу, которая принимает на вхож число (А) и выдает сумму чисел от 1 до А

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

int Sumsimple(int numA)
{
    int sumOfNum = 1;
    for (int i = 2; 1 <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}

int numberA = ReadData("Введите число: ");

int res1 = Sumsimple(numberA);
PrintData("Сумма чисел от 1 до ", res1);