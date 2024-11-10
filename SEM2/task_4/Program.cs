// Напишите программу, которая на вход принимает натуральное число N, а 
// на выходе показывает его цифры через запятую.

int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int numCopy = num;
int count = 0;

while (numCopy != 0)
{
    numCopy /= 10;
    count++;
}

int[] arr = new int[count];
int index = arr.Length - 1;
while (num != 0)
{
    arr[index] = num % 10;
    num /= 10;
    index--;
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]}, ");
}
