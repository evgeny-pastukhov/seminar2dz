// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа 
// должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.


Console.WriteLine("Введите число от 1 до 100 000");
int num = int.Parse(Console.ReadLine());

if (num >= 1 && num <= 100000)
{
    int k = 0;
    int num2 = num;
    while (num2 > 0)
    {
        num2 = num2 / 10;
        k++;
    }
    Console.WriteLine(k);
    int[] array = new int[k];

    for (int i = k - 1; i >= 0; i--)
    {
        array[i] = num % 10;
        num = num / 10;
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Число вне диапазона");
}


