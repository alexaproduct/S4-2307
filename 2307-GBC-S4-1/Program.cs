// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] arr = new int[8];

int max = 0;
int min = 0;
int delta = 0;

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(-10, 10);
    Console.WriteLine(arr[i]);
}

for (int i = 0; i <= 7; i++)
{
    if (arr[i] > max) max = arr[i];
}

Console.WriteLine();
Console.WriteLine("Max: {0}", max);

for (int i = 0; i <= 7; i++)
{
    if (arr[i] < min) min = arr[i];
}

Console.WriteLine();
Console.WriteLine("Min: {0}", min);

delta = max - min;
Console.WriteLine();
Console.WriteLine("Разница между Max и Min: {0}", delta);
