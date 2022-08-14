// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[] enterRatioB = new double[2];
double[] enterRatioK = new double[2];
double[] crossPointLines = new double[2];
for (int i = 0; i <= 1; i++)
{
    Console.Write($"Ввидите коэффициент b{i + 1} : ");
    enterRatioB[i] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Ввидите коэффициент k{i + 1} : ");
    enterRatioK[i] = Convert.ToDouble(Console.ReadLine());
}
if (enterRatioK[0] == enterRatioK[1])
{
    Console.Clear();
    Console.Write($"Прямые y={enterRatioK[0]}*x + {enterRatioB[0]} и y={enterRatioK[1]}*x + {enterRatioB[1]} - парадедльны или совпадают, ввидите другие коэффициенты k & b.");
}
else
{
    crossPointLines[0] = (enterRatioB[1] - enterRatioB[0]) / (enterRatioK[0] - enterRatioK[1]);
    crossPointLines[1] = enterRatioK[0] * crossPointLines[0] + enterRatioB[0];
    Console.Clear();
    Console.Write($" b1 = {enterRatioB[0]}, k1 = {enterRatioK[0]}, b2 = {enterRatioB[1]}, k2 = {enterRatioK[1]} -> (" + string.Join(", ", crossPointLines)+ ")");
}