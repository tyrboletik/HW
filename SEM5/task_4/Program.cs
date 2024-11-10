// Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения.
// Пример входных данных:
// 1 -2 3
// -4 5 -6
// 7 -8 9
// Пример результата:
// 1 2 3
// 4 5 6
// 7 8 9

void ReplaceNegativeNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
            {
                array[i, j] = array[i, j] * (-1);
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array2d =
{
{ 1, -2, 3 },
{ -4, 5, -6 },
};

ReplaceNegativeNumbers(array2d);
PrintArray(array2d);