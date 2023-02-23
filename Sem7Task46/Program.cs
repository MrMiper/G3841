// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Yellow,ConsoleColor.DarkBlue,
                                        ConsoleColor.Cyan,ConsoleColor.DarkGreen,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkCyan,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Gray,
                                        ConsoleColor.Green,ConsoleColor.DarkRed,ConsoleColor.DarkGreen,ConsoleColor.Blue};
int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] outArray = new double[rows, colums];
FillArray2D(outArray);
PrintArray2D(outArray);
System.Random numberSyntezator = new System.Random();

void FillArray2D(double[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for (int j = 0; j < outArray.GetLength(1); j++)
        {
            outArray[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(double[,] outArray)
{
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for (int j = 0; j < outArray.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 14)];
            Console.Write(outArray[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
