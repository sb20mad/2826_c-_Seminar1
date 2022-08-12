//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int B = -number-1;
while (number > B)
{
    Console.WriteLine(number);
    number--;
}