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

// Console.Clear();
// Console.Write("Введите b1: ");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k1: ");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите b2: ");
// double b2 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k2: ");
// double k2 = double.Parse(Console.ReadLine()!);
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > ({x}; {y})");

//Перестановка

void Peremeshenie(string[] array)
{
       for(int j = 0; j < array.Length-1; j++)
     {
        string temp = array[j];
        array[j] = array[j+1];
        array[j+1] = temp;
        Console.WriteLine($"[{string.Join(", ", array)}]");
     }
}

Console.Clear();
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
for( int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i+1} символ: ");
    array[i] = Console.ReadLine();
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Результат: ");
int n1 = 1;
while(n1 <= n)
{
    Peremeshenie(array);
    n1++;
}

