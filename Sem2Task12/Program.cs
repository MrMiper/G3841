// Напиши программу, которая будет принимать 2 числа и выводить ялвется ли 2 число кратное первому, 
//если 2 число не кратное первому, то выводит остаток от 1

int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int res = num2%num1;
if (res == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Некратно " + res);
}