// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите прорграмму,
// которая покажет количество чётных чисел в массиве.

int count = 0;
int[] testArr = Gen1DArr(12, 100, 999);
Parity(testArr);
Print1DArr(testArr);

PrintData("Чётных чисел: ", count);

void Parity(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        count++;
    
       
    }
}
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
void Print1DArr(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
