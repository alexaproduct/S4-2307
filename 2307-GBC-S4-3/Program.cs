// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arr = new int[8];

// Четные
int m = 0;

// Нечетные
int n = 0;

for (int i = 0; i <= 7; i++)
{
    arr[i] = new Random().Next(99, 1000);
    Console.WriteLine(arr[i]);
    if (arr[i]%2 == 0) m = m+1;
}
Console.WriteLine();
Console.WriteLine("Количество четных: {0}", m);