﻿// Напишите программу,которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 ->22

System.Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA> numberB & numberA > numberC)
{
    System.Console.WriteLine("Максимальное число" + numberA);
}
else 
{
    System.Console.WriteLine("Максимальное число" + numberC);
}
if (numberB>numberC)
{
    System.Console.WriteLine("Максимальное число" + numberB);
}