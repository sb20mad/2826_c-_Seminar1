 // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("ВВедите число A ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число B ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число C ");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;
if (B>max) max = B;
if (C>max) max = C;
{
    Console.Write("max = ");
    Console.WriteLine(max);
}