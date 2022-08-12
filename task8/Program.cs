//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("ВВедите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
int number1 = 1, numberB = 2;            
while (true)
{
	if (number1 % 2 == 0)
	{
		Console.Write(number1 + " ");
		numberB=numberB+2;
	}
	if (numberB > numberA)
	{
		break;
	}
	number1++;
}








