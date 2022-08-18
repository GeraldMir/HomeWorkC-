// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.Clear();

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")");
            }
        }
        Console.WriteLine();
    }
}

int[,,] FillRandom3DArray(int lines = 2, int columns = 2, int axisZ = 2, int leftRange = 10, int rethRange = 100)
{
    int[,,] array3D = new int[lines, columns, axisZ];
    Random rand = new Random();
    int[] twistRandomArray = Enumerable.Range(leftRange, (rethRange - leftRange)).ToArray();

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = twistRandomArray[Convert.ToInt32(Math.Round(rand.NextDouble()+ 
                rand.Next(0, twistRandomArray.Length-1)))];
            }
        }
    }
    return array3D;
}

Console.WriteLine('\n' + "Ответ по задаче :");
Console.WriteLine();
Print3DMatrix(FillRandom3DArray());