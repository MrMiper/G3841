// //  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()??"0");

int res = (int)Math.Log10(num)-2;
Console.WriteLine(res < 0 ? "Третьего числа нет" : (num % (int)Math.Pow(10, res + 1) / (int)Math.Pow(10, res)).ToString());
