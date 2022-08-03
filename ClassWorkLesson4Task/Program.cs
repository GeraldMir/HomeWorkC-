//  Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//  7 -> 28
//  4 -> 10
//  8 -> 36
// Console.Write("Виидите А");
// int A = Convert.ToInt32(Console.ReadLine());
//  int sum = 0;
// for (int i = 1; i <= A; i++)
//  {
//   sum=sum+i;  
//  }
// Console.WriteLine($"Результат = {sum}");

//  Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//  456 -> 3
//  78 -> 2
//  89126 -> 5

//  Console.Write("Виидите Число : ");
// int N = Convert.ToInt32(Console.ReadLine());
//  int resalt = 1;
//  while (N>=10)
// {
//    N=N/10;
//     resalt++;
//  }
//  Console.WriteLine($"Результат = {resalt}");

// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.Write("Виидите Число N : ");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= N; i++)
// {
// result=result*i;
// }
// Console.WriteLine($"Результат = {result}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Console.Write("[");
// int[] arr = new int[8];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0, 2);
// }
// Console.Write(string.Join(", ", arr));
// Console.Write("]");