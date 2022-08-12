Console.WriteLine("ВВедите число 1 ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число 2 ");
int numberB = Convert.ToInt32(Console.ReadLine());
// if 
int result = numberA / numberB;
//Console.WriteLine(result);
if (result == numberB)
Console.WriteLine("ДА");
else
{
    Console.WriteLine("НЕТ");
}