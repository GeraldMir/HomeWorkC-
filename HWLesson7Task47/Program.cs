// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:F1} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
const int m = 3;
const int n = 4;
double[,] randomArray = new double[m, n];
Random rand = new Random();
for (int i = 0; i < randomArray.GetLength(0); i++)
{
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        randomArray[i, j] = rand.Next(-10, 11) + rand.NextDouble();
    }
}
PrintMatrixDouble(randomArray);