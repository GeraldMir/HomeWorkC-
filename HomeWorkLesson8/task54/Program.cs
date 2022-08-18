// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();

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
    return randomArray;
}


Console.WriteLine("Исходный массив : ");
int[,] array = FillRandomDoubleArray();
PrintMatrix(array);
Console.WriteLine();


int[,] Sortir(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] > matrix[i, j + 1])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = temp;
                Sortir(matrix);
            }
        }
    }
    return matrix;
}
Console.WriteLine("Отсортированный массив : ");
Sortir(array);
PrintMatrix(array);
Console.WriteLine('\n');