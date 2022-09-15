using static System.Console;

Clear();
Write("Введи трехзначное число : ");
int num1 = Convert.ToInt32(ReadLine()!);
int num2 = num1 % 100;
int num3 = num2 % 10;

Write($"Последнее число: {num3}");
