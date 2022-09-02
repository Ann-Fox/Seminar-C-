// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerFor(int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++) result *= a;
  return result;
}

int PowerRec(int a, int b)
{
  if (b == 0) return 1;
  else return PowerRec(a, b - 1) * a;
}

Console.WriteLine(PowerFor(3, 5));
Console.WriteLine(PowerRec(2, 3));