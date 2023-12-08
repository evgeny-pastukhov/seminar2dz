// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [20,90].

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int k = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 20 && array[i] <= 90) k++;
}
Console.Write(k);