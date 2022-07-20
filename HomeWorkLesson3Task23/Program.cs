// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Ввидите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int evenNumber = 1;
Console.Write(evenNumber);
while (N>evenNumber)
{
    evenNumber= evenNumber+1;
    Console.Write("," + Math.Pow(evenNumber, 3));
}