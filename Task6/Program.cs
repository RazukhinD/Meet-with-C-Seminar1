using static System.Console;

Clear();
Write("Введите число а= ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите число b= ");
int num2 = int.Parse(ReadLine());
Write("Введите число с= ");
int num3 = Convert.ToInt32(ReadLine());
if (num1>num2 & num1>num3)
{
    Write($"Наибольшее из трех введеных чисел: {num1}");
}
else if (num2>num3)
{
    Write($"Наибольшее из двух введеных чисел: {num2}");
}
else
{
    Write($"Наибольшее из двух введеных чисел: {num3}");
}