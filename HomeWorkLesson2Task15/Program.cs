﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int numbDay = Convert.ToInt32(Console.ReadLine());
if (numbDay<1 || numbDay>7)
{
Console.Write($"Цифре {numbDay} нет соответсвующего дня недели, введите цифру в диапазоне от 1 до 7");
}
else
{
    if (numbDay==6 || numbDay==7)
    {
        Console.Write("Да, это выходной");
    }
    else
    {
        Console.Write("Нет, это рабочий день! Работать, товарищи, солнце ещё высоко!");
    }
}