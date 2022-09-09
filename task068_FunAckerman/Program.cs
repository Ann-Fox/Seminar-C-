// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

//           n + 1,                    m = 0;
//  A(m,n)   A(m - 1, 1)               m > 0, n = 0;     
//           A(m - 1, A(m, n - 1))     m > 0, n > 0

int A(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return A(m - 1, 1);
  if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
  return A(m, n);
}

int a = A(2, 3);
Console.WriteLine(a);
int b = A(4, 0);
Console.WriteLine(b);
