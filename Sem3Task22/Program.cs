// int number = ReadInt("Введите число N: ");
// // Делаем цикл от 1 до нашего числа
// for (int i = 1; i <= number; i++)
// { 
//     // Выводим куб числа от 1 до нашего числа
//     Console.Write($"{i*i} ");
// }
// // Функция ввода сообщения
// int ReadInt(string message)
// {

//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t";
    }
    return s;
}
int num = ReadData("Введите число: ");
string line1 = LineBuilder(num, 1);
string line2 = LineBuilder(num, 2);
PrintData(line1, line2);