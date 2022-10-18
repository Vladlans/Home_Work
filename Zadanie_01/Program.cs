//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
{
Console.WriteLine("Введите 2 числа и я скажу какое из них больше");
int a, b;
Console.WriteLine("Введите свое первое число - ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свое второе число - ");
b = Convert.ToInt32(Console.ReadLine());
 
bool move0 = a > b;
bool move1 = a == b;
bool move2 = a < b;
 
if (move0)
{
Console.WriteLine($"Число {a} больше чем {b}");
}
else if (move1)
{
Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
Console.WriteLine($"Число {b} больше чем {a}");
}  
}