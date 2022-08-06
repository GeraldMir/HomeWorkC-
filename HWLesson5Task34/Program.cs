// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
const int leftRange = 100;
const int rightRange = 999;
Console.WriteLine("Введите желаемый размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();

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

int[] array =FillArrayWithRandomNumbers(size, leftRange, rightRange);
int evenNumb = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
        evenNumb+=1;
    }
}
Console.WriteLine('[' + string.Join(", ", array) +"] -> " + evenNumb);