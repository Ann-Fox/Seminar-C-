// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Строки и циклы в решении использовать нельзя!). Цифры подсчитываются справа налево
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());


if (number <= 99)
{
  Console.WriteLine($"{number} -> третьей цифры нет");
}

if (99 < number && number < 1000)
{
  Console.WriteLine($"{number} -> {number / 100}");
}

if (number > 999)
{
  int n321 = number / 100;
  int n3 = n321 % 10;
  Console.WriteLine($"{number} -> {n3}");
}


// if (number < 100) {
// Console.WriteLine($"{number} -> третьей цифры нет");
// }
// while(number => 1000) {
//   number = number / 10;
//   Console.WriteLine(number);



// if (99 < number && number< 1000)
//  {
//   num3 = number % 10;
//   Console.WriteLine($"{number} -> {num3}");
// } 
// else if (number < 100) 
// {
// Console.WriteLine($"{number} -> третьей цифры неt}");
// }


// Console.WriteLine($"{number} -> {number % 10}");


