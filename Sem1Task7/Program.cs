Console.Write("Введите ваше число ");
//Считываем данные с консоли
string? inputNumLine = Console.ReadLine();
//Проверяем, чтобы данные не были пустыми
if(inputNumLine != null)
{
    // Парсим введенное число
int inputNumA = int.Parse(inputNumLine);
// Проверяем последнее число
int lastDigit = inputNumA%10;
// Выводим на экран результат
Console.WriteLine(lastDigit);
}