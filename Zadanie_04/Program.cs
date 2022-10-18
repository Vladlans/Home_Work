//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
if(number <= 0)
{
    Console.WriteLine("Неверное число, повторите попытку");
}
else
{
    while(count <= number)
    {
        int reminder = count % 2;
        if(reminder == 0)
        {
            Console.Write($"{count}. ");
            count++;
        }
        else
        {
            count++;
        }
    }
}