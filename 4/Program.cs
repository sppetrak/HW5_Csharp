// Задача 38: Задайте массив целых чисел от -10 до 10.
// Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];
FillArray(array);
Console.WriteLine(" ");
PrintArray(array);


int minvalue =0;
int maxvalue = 0;

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
}

foreach (int i in array)
{
    if (minvalue > i) minvalue = i;
    if (maxvalue < i) maxvalue = i;
}
Console.WriteLine($"\n Максимальный элемент: {maxvalue}\n Минимальный элемент: {minvalue}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {maxvalue-minvalue}");
