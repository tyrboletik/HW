﻿// Описание: Задайте массив целых чисел.
// Напишите программу, которая проверяет, присутствует ли заданное число в массиве.
// Программа должна вывести: Присутствует/Не присутствует.

int[] array = { 10, 5, 23, 8, 11};
int num = 8; 

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        isExistNum = true;
        break;
    }
}

Console.WriteLine(isExistNum ? "Присутствует" : "Не присутствует");