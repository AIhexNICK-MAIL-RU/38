/* Задача 38: Задайте массив вещественных 
чисел. Найдите разницу между максимальным
 и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
DifferenceMaxMin(numbers);

void PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
}

void DifferenceMaxMin(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int i = 0; array[i] < array[i + 1]; i++)
        {
            int max = i;
            Console.WriteLine(max);
        }
        for (int i = 0; array[i - 1] < array[i]; i++);
        {
            int min = i;
            Console.WriteLine(min);
        }
    }
} 