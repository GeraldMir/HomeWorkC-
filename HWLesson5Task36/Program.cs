// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
const int leftRange = 1;
const int rightRange = 10;
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

int[] array = FillArrayWithRandomNumbers (size, leftRange, rightRange);
int sum=0;
for (int i = 1; i < array.Length; i+=2)
{
    sum=sum+array[i];
}
Console.WriteLine('[' + string.Join(", ", array) +"] -> " + sum);