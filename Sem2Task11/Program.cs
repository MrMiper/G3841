System.Random numSintezator = new System.Random();
int num = numSintezator.Next(100, 1000);
Console.WriteLine(num);
int digit1 = num/100;
int digit2 = num%10;
Console.WriteLine(digit1*10 + digit2);