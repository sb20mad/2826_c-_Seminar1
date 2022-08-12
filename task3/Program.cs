//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("ВВедите число ");
int numberDay = Convert.ToInt32(Console.ReadLine());
// switch (numberDay)
//  {
//  case 1:
//     Console.WriteLine("Понедельник");
//      break;
// case 2:
//      Console.WriteLine("Вторник");
//     break;
//  case 3:
//      Console.WriteLine("Среда");   
// break;
// case 4:
//     Console.WriteLine("Четверг");   
// break;
//  case 5:
//     Console.WriteLine("Пятница");   
//  break;
// case 6:
//      Console.WriteLine("Суббота");   
//  break;
//  case 7:
//      Console.WriteLine("Воскресенье");   
//  break;
// default:
// Console.WriteLine("Попробуйте ещё раз"); 
// break;
//};

if (numberDay == 1)
{
    Console.WriteLine("Понедельник");
}

else if (numberDay == 2)
{
    Console.WriteLine("09Вторник");
}
else if (numberDay == 3)
{
    Console.WriteLine("Среда");
}
else if (numberDay == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberDay == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberDay == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberDay == 7)
{
    Console.WriteLine("Воскресенье");
}
//else
//{
// Console.WriteLine("Попробуйте ещё раз");
//}


else
//(numberDay != 1)
{
    Console.WriteLine("Попробуйте ещё раз");
}