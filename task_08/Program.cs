﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = -number; i < number+1; i++)
{
    if (i%2 == 0 )
    {
        Console.WriteLine(i);
    }
}