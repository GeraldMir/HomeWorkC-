// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.Write("Ввидите номер координатной четверти: ");
int numb = Convert.ToInt32(Console.ReadLine());
if(numb>4 || numb<1) Console.WriteLine("Недопустимое значение");
if (numb == 1) Console.WriteLine("X > 0, Y > 0");
    if (numb == 2) Console.WriteLine("X < 0, Y > 0");
    if (numb == 3) Console.WriteLine("X < 0, Y < 0");
    if (numb == 4) Console.WriteLine("X > 0, Y < 0");