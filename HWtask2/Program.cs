﻿// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечётных позициях.


Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); 
int sum = 0;

Console.Write("Одномерный массив, заполненный случайными числами: "); 
Console.Write("[");
int[] array = new int[length];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-99, 100);
    Console.Write(array[i]);
    if (i < length - 1 ) Console.Write("; ");
    if (i % 2 != 0) sum += array[i];
}
Console.WriteLine("]"); Console.WriteLine(""); 
Console.Write("Cумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(sum);
