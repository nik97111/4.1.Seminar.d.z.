﻿// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, 
// а какое меньшее.
// a = 5, b =7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());

if (numberOne > numberTwo) {
    Console.WriteLine("Первое число - большее, второе - меньшее");
} else if (numberTwo > numberOne) {
    Console.WriteLine("Второе число - большее, первое - меньшее");
} else {
    Console.WriteLine("Все введенные числа одинаковы. Введите другие числа");
}