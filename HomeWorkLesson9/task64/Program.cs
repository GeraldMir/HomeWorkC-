// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Ввидите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NumberPrint(int numb)
{
    if (numb<1)return;
Console.Write(numb + ", ");
NumberPrint(numb-1);
}

Console.Write("N = " + n + " -> "); 
NumberPrint(n);