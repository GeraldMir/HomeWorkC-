// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Ввидите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<=1)
{
    Console.WriteLine("Четных чисел в промежутке от 1 до N - НЕТУ");
}
else
{
int evenNumber = 2;
Console.Write(evenNumber);
while (evenNumber<N && N-evenNumber>1)
{
    evenNumber= evenNumber+2;
    Console.Write("," + evenNumber);
}
}