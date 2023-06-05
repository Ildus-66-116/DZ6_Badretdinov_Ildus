// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите количество чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// int number = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите {i + 1} число: ");
//     array[i] = int.Parse(Console.ReadLine()!);
//     if(array[i] > 0) number = number + 1;
// }
// Console.WriteLine($"Массив: [{string.Join(", ", array)}] -> {number}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > ({x}; {y})");
