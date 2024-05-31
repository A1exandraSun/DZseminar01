// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5-> 2,4
// 8-> 2,4,6,8

System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(System.Console.ReadLine());
int A = 2;

if (N > 1)
{
    while (A <= N)
    {
        System.Console.WriteLine("Чётное число" +A);
        A = A + 2;
    }
}