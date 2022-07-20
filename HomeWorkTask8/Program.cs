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
while (N-evenNumber>1)
{
    evenNumber= evenNumber+2;
    Console.Write("," + evenNumber);
}
// }
// int[] array1 = new int [] {x1, y1};
// int[] array2 = new int [] {x2, y2};

// double distance = Math.Sqrt(Math.Pow(array2[0] - array1[0], 2) + Math.Pow(array2[1] - array1[1], 2));

// Console.WriteLine(distance);
