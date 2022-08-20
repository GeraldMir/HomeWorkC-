// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//  1  2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7

Console.Clear();
Console.WriteLine("Ввидите количество строк :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите количество столбцоов :");
int m = Convert.ToInt32(Console.ReadLine());
int indRow = 0;
int indCol = 0;
int stepCol = 1;
int stepRow = 0;
int amountStep = m;
int countRuns = 0;
int tempOne = 1;
int[,] spiralArray = new int[n, m];
for (int i = 0; i < spiralArray.Length; i++)
{
    spiralArray[indRow, indCol] = 1 + i;
    amountStep -= 1;
    if (amountStep == 0)
    {
        if (countRuns % 2 == 0) { tempOne += 1; }
        amountStep = (countRuns % 2) * m + ((countRuns + 1) % 2) * n - (countRuns / 2 - 1) - 2;
        countRuns += 1;
        int tempTwo = stepCol;
        stepCol = -1 * stepRow;
        stepRow = tempTwo;
    }
    indRow += stepRow;
    indCol += stepCol;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString("0#") + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(spiralArray);
