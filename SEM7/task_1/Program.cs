// Напишите программу, которая выведет все натуральные числа в промежутке 
// от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8


void PrintNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        if (m == n)
        {
            return;
        }
        PrintNaturalNumbers(m + 1, n);
    }
    else
    {
        Console.Write($"{n} ");
        if (n == m)
        {
            return;
        }
        PrintNaturalNumbers(n + 1, m);
    }
}

Console.Write("Введите натуральное число M: \n");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: \n");
int num2 = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(num1, num2);