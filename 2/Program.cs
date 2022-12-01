//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] numbers = new int[10];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Масcив из 10 чисел: ");
PrintArray(numbers);

int sum = 0;

for (int a = 0; a < numbers.Length; a += 2)
    sum = sum + numbers[a];

Console.WriteLine($"Cумма элементов на нечётных индексах = {sum}");

/* void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 10);
    }
} */

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}