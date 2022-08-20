// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 = 1*2*3*4
// 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int product(int a)
{
  int prod = 1;
  for (int i = 2; i <= num; i++)
  {
    prod = prod * i; //prod*=i;
  }
  return prod;
}
Console.Write($"{num} -> ");
Console.Write(product(num));

// int prod = 1;
// for (int i = 1; i <= num; i++)
// {
// prod = prod * i;
// }
// Console.Write($"{num} -> {prod}");