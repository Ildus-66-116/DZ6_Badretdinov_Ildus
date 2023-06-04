// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
int number = 0;
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    array[i] = int.Parse(Console.ReadLine()!);
    if(array[i] > 0) number = number + 1;
}
Console.WriteLine($"Массив: [{string.Join(", ", array)}] -> {number}");
