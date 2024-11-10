//Напишите программу, которая перевернёт одномерный массив 

{
    int[] numbers = { 1, 2, 3, 4, 5, 6 };
    int temp;

    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }

    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }

    Console.Write(" => ");
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
}