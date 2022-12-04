// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
int[] array2 =new int[size];
Console.WriteLine(" ");
PrintArray(array);
MultiplyPairs(array);
Console.WriteLine(" ");
PrintArray2(array2);




void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "}");
    }
}

void MultiplyPairs(int[] аrray)
    {
    for(int i = 0; i < array.Length/2; i++)
    {
      array2[i] = array[i] * array[array.Length - i - 1];
    }
     }

void PrintArray2(int[] array2)
{
    for(int i = 0; i < array2.Length/2; i++)
    {
        Console.Write($"{array2[i] + " "}");
    }
}
