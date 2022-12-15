/*Напишите программу, которая на вход
принимает число и выдаёт его квадрат (число
умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49*/

Console.Write("Введите число = ");
float user_input = float.Parse(Console.ReadLine()!);
float square = user_input * user_input;
Console.WriteLine($"Квадрат числа {user_input} равен >>> {square}");