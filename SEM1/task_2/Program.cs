﻿// Напишите метод, который принимает на вход три числа и возвращает среднее из этих чисел
// (то есть не самое большое и не самое маленькое).

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

{
    while ((a >= b && a <= c) || (a >= c && a <= b))
    {
        Console.Write(a);
        return;
        
    }
    if ((b >= a && b <= c) || (b >= c && b <= a))
    {
        Console.Write(b);
        return; 
    }
    else
    {
        Console.Write(c);
        return; 
    }
}
