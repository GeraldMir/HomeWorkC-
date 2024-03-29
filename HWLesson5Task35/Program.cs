﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
const int leftRange = 0;
const int rightRange = 999;
const int sizeTask = 123;

int ChangeSizeArray(string text1, string text2, int sizeArray)
{
    Console.WriteLine(text1);
    string userAnsw = Console.ReadLine();
    if (userAnsw.ToLower() == "yes" || userAnsw.ToLower() == "y" || userAnsw.ToLower() == "да" || userAnsw.ToLower() == "д")
    {
        Console.WriteLine(text2);
        int newSizeArray = Convert.ToInt32(Console.ReadLine());
        sizeArray = newSizeArray;
        return sizeArray;
    }
    return sizeArray;
}

int size = ChangeSizeArray("Изменить размер массива для провекри со 123 на желаемый ? (введите Да/Нет или Y/N): ", "Ввидете желаемый размер массива: ", sizeTask);
// int size = sizeTask; Сделал метод который предлагает поменять размер массива для проверки

int[] FillArrayWithRandomNumbers(int sizeArr, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[sizeArr];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
int amout = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 100)
    {
        amout += 1;
    }
}
Console.WriteLine('[' + string.Join(", ", array) + "] -> " + amout);