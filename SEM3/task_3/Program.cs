﻿// Описание: Задайте массив из 10 целых чисел. Найдите среднее значение элементов массива.

int[] array = { 11, 25, 34, 49, 53, 26, 87, 8, 95, 16 };
int i = 0;
double sum = 0;

while (i < array.Length)
{
 sum = sum + array[i];
 i++;
}

double average = sum / array.Length;
{
    Console.Write(average);
}