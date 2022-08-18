// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[,] FillRandomDoubleArray(int lines = 4, int columns = 4, int leftRange = 0, int rethRange = 10)
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

void MaxSumMatrixLines(int[,] matrix)
{
    int numMin = 2147483647;
    int[] arraySumElementsLines = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElementsLines = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElementsLines = sumElementsLines + matrix[i, j];
        }
        arraySumElementsLines[i] = sumElementsLines;
        if (arraySumElementsLines[i] < numMin) { numMin = arraySumElementsLines[i]; }
    }
    Console.WriteLine("Строка с минимальной суммой элементов массива: " + Array.IndexOf(arraySumElementsLines, numMin));
}

MaxSumMatrixLines(array);
