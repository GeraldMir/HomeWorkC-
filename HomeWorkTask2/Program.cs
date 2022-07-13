// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
Console.Write("Ввидите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst==numberSecond)
{
Console.WriteLine("Числа одинаковые");
}
else
{
if (numberFirst>numberSecond)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}
}