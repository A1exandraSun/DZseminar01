// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да 
//-3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число");
string num = Console.ReadLine();
int numberA = Convert.ToInt32(num);
int numberB = 2;

if (numberA % numberB == 0)
{
    System.Console.WriteLine("Это чётное число" + numberA);
}
else
    System.Console.WriteLine("Это нечётное число" + numberA);
