// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void PrintNaturalNumbers(int num)
{
    if (num == 0) return;
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number);

// хвостовая рекурсия
// void PrintNaturalNumbers(int num) 5 4 3 2 1
// {
//     if(num == 0) return ;
//     Console.Write($"{num} ");
//     PrintNaturalNumbers(num -1);
// }

// Console.WriteLine("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// PrintNaturalNumbers(number);