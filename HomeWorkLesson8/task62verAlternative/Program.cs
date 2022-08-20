// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//  1  2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7

// Пока пытался додуматься как решить задачу - написал программу для заполнения змейкой.
// План был таков, чтобы поочердно они работали - то срочку то столбец заполняли, но 
// что-от пошло не так :) Совместить их у меня не вышло.

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


int[,] FillArraySnake(int row, int col)
{
    int[,] matrix = new int[row, col];
    int countRow = row;
    int countCol = col;
    int countTotal = 1;
    int directLines = 1;
    int directColumns = 1;

// вот заполнение по строчкам. 

    // while (countRow > 0)
    // {
    //     if (directLines == 1)
    //     {
    //         for (int j = col - countCol; j < countCol; j++)
    //         {
    //             matrix[row - countRow, j] = countTotal;
    //             countTotal++;
    //         }
    //         directLines *= -1;
    //     }
    //     else
    //     {
    //         for (int j = countCol - 1; j > col - countCol - 1; j--)
    //         {
    //             matrix[row - countRow, j] = countTotal;
    //             countTotal++;
    //         }
    //         directLines *= -1;
    //     }
    //     countRow -= 1;
    // }

// Вот заполнение змейкой по столбцам:

    while (countCol > 0)
    {
        if (directColumns == 1)
        {
            for (int i = row - countRow; i < countRow; i++)
            {
                matrix[i, col - countCol] = countTotal;
                countTotal++;
            }
            directColumns *= -1;
        }
        else
        {
            for (int i = countRow - 1; i > row - countRow - 1; i--)
            {
                matrix[i, col - countCol] = countTotal;
                countTotal++;
            }
            directColumns *= -1;
        }
        countCol -= 1;
    }
    return matrix;
}



Console.WriteLine("результат");
PrintMatrix(FillArraySnake(3, 3));
