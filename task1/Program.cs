// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3


Console.WriteLine("введите число 1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2:");
int num2 = int.Parse(Console.ReadLine());
int num2sqr =num2*num2;
if (num2sqr==num1)
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
    Console.WriteLine("первое число не является квадратом второго");
}

