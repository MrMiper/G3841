// Создаем генератор случайного числа
System.Random numSintezator = new System.Random();
// Число будет от 100 до 999, то есть 3-х значное
int num = numSintezator.Next(100, 1000);
// Выводим полученное число
Console.WriteLine(num);
// делим его на 100 и выводим остаток от деления на 10
int digit1 = num/100;
int digit2 = num%10;
// Выводим первую и третью цифры
Console.WriteLine(digit1*10 + digit2);