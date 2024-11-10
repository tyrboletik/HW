﻿// Напишите метод, который на вход принимает число и выводит, является ли оно положительным (больше нуля),
// отрицательным (меньше нуля) или нулём.

Console.Write("number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 <= 0)
{
    Console.WriteLine("отрицательное");
}
else
{
    Console.WriteLine("положительное");