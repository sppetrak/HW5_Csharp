//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[10];

FillArrayRandom(array);
Console.WriteLine("Масcив из 10 чисел: ");
PrintArray(array);

int sum = 0;

for (int a = 0; a < array.Length; a += 2)
    sum = sum + array[a];

Console.WriteLine($"Cумма элементов на нечётных индексах = {sum}");

//  void FillArrayRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
//     }
// } 

void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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