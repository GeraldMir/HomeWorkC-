// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.Write("Ввидите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m<0 || n<0)
{
    Console.Write("Ввидите числа БОЛЬШЕ НУЛЯ !!!");
}
else
{
   Console.WriteLine("функция аккермана для введённых m и n = "+AkkermanFunct(m,n));
}

int AkkermanFunct(int numM, int numN)
{
if (numM==0) return numN+1;
if (numN==0) return AkkermanFunct(numM-1, 1);
return AkkermanFunct(numM-1, AkkermanFunct(numM, numN-1));
}