using static System.Console;

Clear();
Write("Введите число: ");

int num1=Convert.ToInt32(ReadLine());
int i=1;

while (i<=num1)
{
 if (i%2==0)
 {
    Write($"{i} ");
    i++;
 }
 else
 {
    i++;
 }
}
