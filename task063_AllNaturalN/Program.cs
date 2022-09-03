// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string NumbersFor(int N)
{
  string result = String.Empty;
  for (int i = 1; i <= N; i++)
  {
    result += $"{i} ";
  }
  return result;
}

//Если первый аргумент не задан?
string NumbersRec(int N)
{
  int i = 1;
  if (i == N) return N.ToString();
  return N + " " + NumbersRec(N - 1); 
  
}

Console.WriteLine(NumbersFor(5));
Console.WriteLine(NumbersRec(5));