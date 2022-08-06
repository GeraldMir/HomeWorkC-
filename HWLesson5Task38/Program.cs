// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Введите желаемый размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
}
double numMax = array[0];
double numMin = array[0];
for (int i = 0; i < array.Length; i++)
{
      if (array[i]>numMax)
    {
        numMax=array[i];
    }
    if (array[i]<numMin)
    {
        numMin=array[i];
    }  
}
Console.WriteLine('[' + string.Join("; ", array) + "] -> " + (numMax-numMin));