// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int[] dotA = new int[3];
Console.Write("Ввидите координату X первой точки (А): ");
dotA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите координату Y первой точки (А): ");
dotA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите координату Z первой точки (А): ");
dotA[2] = Convert.ToInt32(Console.ReadLine());
int[] dotB = new int[3];
Console.Write("Ввидите координату X второй точки (B): ");
dotB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите координату Y второй точки (B): ");
dotB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите координату Z второй точки (B): ");
dotB[2] = Convert.ToInt32(Console.ReadLine());
double resalt = Math.Sqrt(Math.Pow(dotB[0]-dotA[0], 2)+Math.Pow(dotB[1]-dotA[1], 2)+Math.Pow(dotB[2]-dotA[2], 2));
Console.Write("A ({0}); ", string.Join(", ", dotA));
Console.Write("B ({0}) -> ", string.Join(", ", dotB));
Console.Write(string.Format("{0:F2}", resalt));