// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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



int[,] array = FillRandomDoubleArray();
double[] averageColumnsArray = new double[array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++)
{
    int sumElementsColumns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumElementsColumns = sumElementsColumns + array[i, j];
        averageColumnsArray[j] = Math.Round((Convert.ToDouble(sumElementsColumns) / array.GetLength(0)), 1);
    }
}

PrintMatrix(array);

Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: " + string.Join("; ", averageColumnsArray));