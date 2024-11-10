// Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).

// Пример входных данных:
// 1 2
// 3 4
// 5 6
// Пример результата:
// 1 3 5
// 2 4 6
void GetTransposesMatrix(int[,] array)
{
    Console.WriteLine("Входные данные:");
    int[,] transposed = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            transposed[j, i] = array[i, j];
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Результат:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{transposed[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array2d ={
    {1, 2, 1, 2 },
    {3, 4, 3, 4 },
    {5, 6, 5, 6 }
};

GetTransposesMatrix(array2d);
