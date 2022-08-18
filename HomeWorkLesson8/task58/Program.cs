// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] FillRandomDoubleArray(int lines = 3, int columns = 3, int leftRange = 0, int rethRange = 10)
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

Console.WriteLine('\n' + "Первая матрица: ");
int[,] matrixOne = FillRandomDoubleArray();
PrintMatrix(matrixOne);
Console.WriteLine('\n' + "Вторая матрица :");
int[,] matrixTwo = FillRandomDoubleArray();
PrintMatrix(matrixTwo);

int[,] MatrixMultiplicationElements(int[,] arrayDoubleOne, int[,] arrayDoubleTwo)
{
    int[,] stop = new int[0, 0];
    if (arrayDoubleOne.GetLength(0) != arrayDoubleTwo.GetLength(0) || arrayDoubleOne.GetLength(1) != arrayDoubleTwo.GetLength(1))
    {
        Console.WriteLine('\n' + "Поэлементное перемножение матриц невозможно!" +
    '\n' + "Задайте новыве матрицы, чтобы количество столбцов и строк в обеих матрицах совпадали" + '\n');
        return stop;
    }
    int[,] resultMatrix = new int[arrayDoubleOne.GetLength(0), arrayDoubleOne.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = arrayDoubleOne[i, j] * arrayDoubleTwo[i, j];
        }
    }
    return resultMatrix;
}

Console.WriteLine('\n' + "Поэлементное перемножение :");
PrintMatrix(MatrixMultiplicationElements(matrixOne, matrixTwo));

int[,] AlgebraicalMultirlicationElements(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] stop = new int[0, 0];
    int[,] resultAlgebMatrx = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0))
    {
        Console.WriteLine('\n' + "Алгебраическое перемножение матриц невозможно!" +
        '\n' + "Задайте новыве матрицы, чтобы количество столбцов первой равнялось количеству строк второй" + '\n');
        return stop;
    }
    else
    {
        for (int i = 0; i < resultAlgebMatrx.GetLength(0); i++)
        {
            for (int j = 0; j < resultAlgebMatrx.GetLength(1); j++)
            {
                for (int k = 0; k < matrixSecond.GetLength(0); k++)
                {
                    resultAlgebMatrx[i, j] = resultAlgebMatrx[i, j] + matrixFirst[i, k] * matrixSecond[k, j];
                }
            }
        }
    }
    return resultAlgebMatrx;
}

Console.WriteLine('\n' + "Алгебраическое перемножение матриц:");
PrintMatrix(AlgebraicalMultirlicationElements(matrixOne, matrixTwo));
Console.Write('\n');