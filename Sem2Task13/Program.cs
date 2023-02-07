// //  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
// Присвоение вводимого числа
int num = int.Parse(Console.ReadLine()??"0");
// Нахождение первого числа с помощью логорифма и сдвиг на 2 цифры
int res = (int)Math.Log10(num)-2;
Console.WriteLine(res < 0 ? "Третьего числа нет" : (num % (int)Math.Pow(10, res + 1) / (int)Math.Pow(10, res)).ToString());
