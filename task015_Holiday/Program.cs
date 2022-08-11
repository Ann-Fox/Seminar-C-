/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число: ");
int day = int.Parse(Console.ReadLine());

if (0 < day && day < 6)
{
  Console.WriteLine($"{day} -> no");
}
else if (day == 6 || day == 7)
{
  Console.WriteLine($"{day} -> yes");
}
else
{
  Console.WriteLine("Введено некоректное число");
}


// switch (day)
// {
//   case 1:
//     Console.WriteLine($"{day} -> no");
//     break;
//   case 2:
//     Console.WriteLine($"{day} -> no");
//     break;
//   case 3:
//     Console.WriteLine($"{day} -> no");
//     break;
//   case 4:
//     Console.WriteLine($"{day} -> no");
//     break;
//   case 5:
//     Console.WriteLine($"{day} -> no");
//     break;
//   case 6:
//     Console.WriteLine($"{day} -> yes");
//     break;
//   case 7:
//     Console.WriteLine($"{day} -> yes");
//     break;
//     default:
//       Console.WriteLine("Введено некоректное число");
//       break;
// }