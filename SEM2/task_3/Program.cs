// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10 && num <= 99)
{
    int firstdDigit = num / 10;
    int secondDigit = num % 10;

    if (firstdDigit > secondDigit)
    {
        Console.WriteLine(firstdDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}