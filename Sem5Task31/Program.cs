// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
// Найти сумму отрицательный и положительных элементов массива.

int posetiveSum = 0;
int negativeSum = 0;

int[] testArr = Gen1DArr(12, -9, 9);
NegPosSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", posetiveSum);
PrintData("Сумма отрицательных чисел в массиве: ", negativeSum);
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

void NegPosSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posetiveSum += arr[i];
        }
        else
        {
            negativeSum += arr[i];
        }
    }
}