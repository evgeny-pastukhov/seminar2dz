﻿// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.

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
    if (array[i] % 2 == 0) k++;
}
Console.Write(k);