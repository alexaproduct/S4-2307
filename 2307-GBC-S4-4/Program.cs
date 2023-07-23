// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Sasha and Dima!");

// Задача 6 - Показать кубы чисел,
// заканчивающихся на четную цифру

Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (i%2 == 0)
    {
         Console.WriteLine($"{i} x {i} x {i} = {i*i*i}");
    }
}
Console.WriteLine();
