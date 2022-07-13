// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Ввидите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());
if (numberFirst == numberSecond && numberFirst == numberThird)
{
    Console.WriteLine("Числа одинаковые");
}
else
{
    int maxNumber = -1;
    if (numberFirst > maxNumber)
    {
        maxNumber = numberFirst;
    }
    if (numberSecond > maxNumber)
    {
        maxNumber = numberSecond;
    }
    if (numberThird > maxNumber)
    {
        maxNumber = numberThird;
    }
    Console.WriteLine($"Максимальное число = {maxNumber}");
}