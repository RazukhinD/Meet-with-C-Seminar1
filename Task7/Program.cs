using static System.Console;

Clear();
Write("Введите число : ");
int num1 = Convert.ToInt32(ReadLine()!);

if (num1%2 == 0)
{
    Write("Четное");
}
else
{
    Write("Нечетное");
}

