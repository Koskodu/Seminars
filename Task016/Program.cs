﻿/*Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/


Console.WriteLine("Введите число:");
int usernumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int usernumber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(usernumber1, usernumber2) ? "да" : "нет");

bool IsSquare(int n1, int n2)
{
    return n1 / n2 == n2 || n2 / n1 == n1;
}