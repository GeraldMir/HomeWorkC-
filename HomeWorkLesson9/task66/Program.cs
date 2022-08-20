// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Ввидите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m>n)
{
    Console.WriteLine("Ввидите новые числа, чтобы M было больше N");
}
else
{
    Console.WriteLine("M ="+m+"; N ="+n+ " -> "+PrintSumNumbers(m,n));
}

int PrintSumNumbers(int numOne, int numTwo)
{
// int sum=numOne;
if (numOne>numTwo-1)return numOne;
return numOne+PrintSumNumbers(numOne+1, numTwo);
}