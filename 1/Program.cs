//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int[10];

FillArrayRandomNumbers(array);
Console.WriteLine("Массив трехзначных чисел");
PrintArray(array);

int count = 0;

for (int a = 0; a < array.Length; a++)
    if (array[a] % 2 == 0)
        count++;

Console.WriteLine($"количество четных чисел: {count}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
