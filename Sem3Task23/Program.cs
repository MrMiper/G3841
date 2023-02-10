//Напишите программу, которая принимает на 
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Вводим число
int number = ReadInt("Введите число N: ");
// Делаем цикл от 1 до нашего числа
for (int i = 1; i <= number; i++)
{ 
    // Выводим куб числа от 1 до нашего числа
    Console.Write($"{i*i*i} ");
}



// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}