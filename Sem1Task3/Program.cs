// Задание номер №3
// Напишите программу, которая будет
// выдавать название дня недели по заданному
// номеру.
// Считываем данные с консоли второе число
string? imputLine = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(imputLine!=null)
{
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "СУббота";
dayOfWeek[6] = "Воскресенье";
int imputNum = int.Parse(imputLine);
string outDayOfWeek = dayOfWeek[imputNum -1];
Console.WriteLine(outDayOfWeek);
}
