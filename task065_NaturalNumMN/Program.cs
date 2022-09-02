// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string NumbersFor(int M, int N)
{
  string result = String.Empty;
  for (M = 1; M <= N; M++)
  {
    result += $"{M} ";
  }
  return result;
}

//Если первый аргумент не задан?
string NumbersRec(int M, int N)
{
  if (M <= N) return $"{M} " + NumbersRec(M+1,N);
  else return String.Empty;
}

Console.WriteLine(NumbersFor(1,5));
Console.WriteLine(NumbersRec(4,8)); 