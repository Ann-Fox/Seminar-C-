// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int NumbersRec(int M, int N)
{
  int result = 0;
  if (M <= N) return (result += M) + NumbersRec(M + 1, N);
  else return result;
}

Console.WriteLine(NumbersRec(1, 15));
Console.WriteLine(NumbersRec(4, 8));

// int NumbersFor(int M, int N)
// {
//   int mStart = M;
//   int result = 0;
//   for (; M <= N; M++)
//   {
//     result += M;
//   }
//   Console.WriteLine($"M = {mStart}; N = {N} -> {result}");
//   return result;
// }

// int elem1 = NumbersFor(1, 15);
// Console.WriteLine(elem1);

// Console.WriteLine(NumbersFor(4, 8));

