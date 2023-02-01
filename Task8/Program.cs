// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    N*=-1;
}

for(int i = 2; i <=N; i = i + 2)
{
    System.Console.Write(i + " ");
}

