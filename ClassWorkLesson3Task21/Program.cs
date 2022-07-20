// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 2D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.Clear();
// Console.Write("Ввидите X первой точки: ");
// Console.Write("Ввидите Y первой точки: ");
// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4 Math.Abs()
Console.Clear();
Console.Write("Ввидите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int evenNumber = 1;
Console.Write(evenNumber);
while (N>evenNumber)
{
    evenNumber= evenNumber+1;
    Console.Write("," + Math.Pow(evenNumber, 2));
}