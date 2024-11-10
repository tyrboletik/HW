// Напишите метод, который на вход принимает число (number),
// а на выходе выводит все нечетные числа от 1 до number (включительно),
// после каждого числа должен быть знак пробела.

Console.WriteLine("number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i += 2)
{
    Console.Write(i + " ");
}