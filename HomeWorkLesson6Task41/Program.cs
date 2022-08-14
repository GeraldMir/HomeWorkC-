// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter).
// Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0 7 8 -2 -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Ввидите любые числа  через пробел ");
string[] uzerArray= Console.ReadLine().Split();
int result =0;
for (int i = 0; i < uzerArray.Length; i++)
{
    if (Convert.ToInt32(uzerArray[i]) > 0)
    {
        result++;
    }
}
Console.Write($"Введённые числа  {string.Join(", ", uzerArray)} -> {result} (количество чисел больше нуля)");