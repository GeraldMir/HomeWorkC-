﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Ввидите число из диапозона от 100 до 999: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 1000 && numb>99)
{
Console.Write("Вторая цифра числа = "+(numb%100)/10);
}
else
{
Console.WriteLine("Введено число не из заданного диапозона;");
}