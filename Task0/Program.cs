using static System.Console;

Clear();
Write("Введите число а=");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите число b=");
int num2 = int.Parse(ReadLine());
int sqr1 = num1*num1;
int sqr2 = Convert.ToInt32(Math.Pow(num2,2));
WriteLine($"Квадрат числа [a] равен: {sqr1}");
WriteLine($"Квадрат числа [b] равен: {sqr2}");


