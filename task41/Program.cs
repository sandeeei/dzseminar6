﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int size =Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

//заполнение массива пользователеь

for (int i = 0; i < size; i++)
{
    Console.Write($"Введите элемент массива под индексом  {i}: \t");
    array[i]=Convert.ToInt32(Console.ReadLine());
}

//Подщет чисел больше 0 в массиве

int count = 0;

for (int i = 0; i < size; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"\n Введенныйе числа : [{String.Join("; ", array)}]");
Console.WriteLine($"\n Вы ввели   {count} чисел больше 0");