// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumbers(10, -10, 10);
Console.WriteLine('[' + string.Join(", ", array) + ']');
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.Write("Введите число от -10 до 10, которое надо найти в массиве: ");
int numb = Convert.ToInt32(Console.ReadLine());

 CheckNumberArray (array, numb);
 
void CheckNumberArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
      if (number==array[i])
      {
        Console.WriteLine("Да");
        return;
      }
    }
Console.WriteLine("Нет");
}


