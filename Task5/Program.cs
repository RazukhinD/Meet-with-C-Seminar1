using static System.Console;

Clear();
Write("Введите число а=");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите число b=");
int num2 = int.Parse(ReadLine()!);
if (num1>num2)
{
    Write($"Наибольшее из двух введеных чисел: {num1}");
}
else
{
    Write($"Наибольшее из двух введеных чисел: {num2}");
}

