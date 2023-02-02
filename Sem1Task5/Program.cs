Console.Write("Введите ваше число ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if(inputNum != null)
{
     // Парсим введенное число
    int num = int.Parse(inputNum);
    // Просим выявить минус указанного числа и прибавлять по единице пока не дойдем до указанного числа
    for (int i = 0; i < num*2; i++)
{
    Console.Write(i-num);
    Console.Write(", ");
    
}
Console.Write(num);
}

