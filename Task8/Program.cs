﻿//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int length = num;

for (int i = 2; i <= length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write("{0} ", i);
    }
}