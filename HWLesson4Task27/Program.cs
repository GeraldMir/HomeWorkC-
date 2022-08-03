// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите любое число : ");
int numbA = Convert.ToInt32(Console.ReadLine());
int initialA = numbA;
int result = 0;
while (numbA>=1)
{
    result=result+numbA%10;
    numbA/=10;
}
Console.Write($"Сумма цифр введённого числа {initialA} равно: " + result );