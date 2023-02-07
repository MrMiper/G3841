// // Напиши программу, которое принимает число и выводит кратное ли число 7 и 23

int num = int.Parse(Console.ReadLine()??"0");
int res1 = num%7;
int res2 = num%23;
if ((res1 == 0) && (res2 == 0))
{

    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Некратно ");
}