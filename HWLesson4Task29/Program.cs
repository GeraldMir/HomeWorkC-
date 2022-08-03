// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите {i+1}-й элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
Console.Write("[" + string.Join(", ", arr) + "]");