//Напишите программу для вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return 0;

    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackermann(n - 1, 1);
    }
    else
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
}

Console.Write("Введите неотрицательное число m: \n");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: \n");
int num_2 = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(num_1, num_2);
Console.WriteLine($"{result}");