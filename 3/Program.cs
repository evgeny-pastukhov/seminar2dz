// Задайте массив из вещественных чисел 
// с ненулевой дробной частью. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.


double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double min = array[1];
double max = array[1];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine($"max ={max}");
Console.WriteLine($"min ={min}");
Console.WriteLine(max - min);
