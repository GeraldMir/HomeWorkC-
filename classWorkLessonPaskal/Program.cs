// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

void PrintMatrixPaskal(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int g = 0; g < matrix.GetLength(0)-i; g++)
       {
        Console.Write("   ");
       }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                Console.Write(string.Format("{0:   ###  }", matrix[i, j]));
// КАК НАСТРОИТЬ ВЫВОД, ЧТОБЫ БЫЛО ИДЕАЛЬНЫЙ ТРЕУГОЛЬНИК НА ЛЮБОМ КОЛИЧЕСТВЕ СТРОЧЕК??? у меня хорошо выглядит до 10 строчек
            } 
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Ввидите количество желаемое количество строк N : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] paskalTriangl = new int[n, n];
for (int i = 0; i < paskalTriangl.GetLength(0); i++)
{
    for (int j = 0; j < paskalTriangl.GetLength(1); j++)
    {
        if (i == j || j == 0)
        {
            paskalTriangl[i, j] = 1;
        }
        if ((i - j) > 0 && i >= 1 && j >= 1)
        {
            paskalTriangl[i, j] = paskalTriangl[i - 1, j - 1] + paskalTriangl[i - 1, j];
        }
    }
}
Console.WriteLine('\n');
PrintMatrixPaskal(paskalTriangl);
Console.WriteLine('\n');
