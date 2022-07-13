// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Ввидите число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
if (numberFirst % 2 == 0)
{
    Console.WriteLine($"Введенное число {numberFirst} является чётным, ответ ДА");
}
else
{
    Console.WriteLine($"Введенное число {numberFirst} является нечётным, ответ - НЕТ");
}