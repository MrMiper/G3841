// // Напишите программу, которая принимает 2 числа и выводит, является ли одно число квадратом второго
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

// if (num1*num1 == num2)
// {
//     Console.WriteLine("Первое число квадрат первого");
// }
// else 
// {
// if (num2*num2 == num1)
// {
//       Console.WriteLine("Второе число квадрат первого");
// }
// else 
// {
//       Console.WriteLine("Не квадрат");
// }
// }
TestSQRT(num1, num2);
TestSQRT(num2, num1);
void TestSQRT(int i, int j)
{
    if (i*i==j)
    {
    Console.WriteLine("Число " + i + " не является квадратом числа " + j );
    }
else 
{
      Console.WriteLine("Число " + j + " является квадратом числа " + i );
}
}