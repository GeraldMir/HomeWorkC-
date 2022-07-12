// Задача 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Ввидите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
if (numberFirst%7==0 && numberFirst%23==0)
{
    Console.WriteLine("Число кратно, ответ ДА");
}
else
{
Console.WriteLine("Введеное число одновренно не является кратным 7 и 23, ответ НЕТ");
}