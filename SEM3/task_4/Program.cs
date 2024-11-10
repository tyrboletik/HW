﻿// Описание: Задайте массив целых чисел. Напишите программу, которая удаляет все отрицательные числа из массива и возвращает новый массив,
// содержащий только неотрицательные числа.

int[] numbers = { 10, -5, 16, -10, 0, 23, -71, 30, };
int[] RemoveNegatives(int[] numbers)
{
    return numbers.Where(n => n >= 0).ToArray();
}
{
    int[] result = RemoveNegatives(numbers);
    Console.WriteLine("[" + string.Join(", ", result) + "]");
}