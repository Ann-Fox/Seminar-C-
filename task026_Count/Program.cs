// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int count = 0;
// int num = n;

// while (n > 0)
// {
//   count++;
//   n = n / 10;
// }
// Console.Write($" {num} -> {count}");

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int DiditCount(int a)
{
  int count = 0;
  while (a > 0)
  {
    count++;
    a /= 10;
  }
  return count;

}
Console.Write(DiditCount(num));