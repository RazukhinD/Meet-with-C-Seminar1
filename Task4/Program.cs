using static System.Console;

Clear();
Write("Введи трехзначное число : ");
int num1 = Convert.ToInt32(ReadLine()!);


Write($"Последнее число: {num1%10}");
