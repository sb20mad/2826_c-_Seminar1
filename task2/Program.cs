//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("ВВедите число A ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите число B ");
int B = Convert.ToInt32(Console.ReadLine());

int max = A;
int min = B;

if (B>max) max = B; min = A;
{
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
