// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Ввидите строку элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите столбец элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

ChangeArray("Ввидите Y или Да, чтобы использовать массив из примера", "Тогда будем использовать рандомный 2х-мерный массив");

void ChangeArray(string text1, string text2)
{
    Console.WriteLine(text1);
    string userAnsw = Console.ReadLine();
    if (userAnsw.ToLower() == "yes" || userAnsw.ToLower() == "y" || userAnsw.ToLower() == "да" || userAnsw.ToLower() == "д")
    {
        int[,] newArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }};
        return newArray[3,4];
    }
    else
    {
        return Console.Write(text2);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillRandomDoubleArray(int lines = 3, int columns = 4, int leftRange = -10, int rethRange = 10)
{
    int[,] randomArray = new int[lines, columns];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = rand.Next(leftRange, rethRange + 1);
        }
    }
    return randomArray[lines, columns];
}