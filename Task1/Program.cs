using static System.Console;

Clear();
Write("Введите число а=");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите число b=");
int num2 = int.Parse(ReadLine()!);
int sqr1 = num2*num2;
if (num1 == sqr1)
{
    WriteLine("Yes");
}
else
{
    WriteLine("No");
}


