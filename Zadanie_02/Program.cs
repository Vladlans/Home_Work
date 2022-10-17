//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
{
int num1, num2, num3;
Console.Write("Найти наибольшее из 3 чисел:\n");

Console.Write("Введите первое число :");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число :");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число :");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
    Console.Write("Первое число самое большое.");
    }
    else
    {
    Console.Write("Третье число самое большое.");
    }
    }
    else if (num2 > num3)
    Console.Write("Второе число самое большое.");
    else
    Console.Write("Треьте число самое большое.");
}