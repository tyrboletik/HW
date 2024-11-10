// Напишите метод, который на вход принимает два целых числа и проверяет, делится ли первое число на второе.
// Если делится, выводите "делится", иначе выводите "не делится".

Console.Write("firstNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("secondNumber: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

{
    if (secondNumber == 0)
    {
        Console.WriteLine("На ноль делить нельзя");
    }
    else if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine("делится");
    }
    else
    {
        Console.WriteLine("не делится");
    }
}