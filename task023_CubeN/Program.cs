// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());


if (N > 0)
{
  Console.Write("N -> ");

  for (int i = 1; i <= N; i++)
  {
    // double k = Math.Pow(i, 3);
    // Console.Write(k + ", ");
    if (i == N)
    {
      Console.Write(Math.Pow(i, 3));
    }
    else
    {
      Console.Write(Math.Pow(i, 3) + ", ");
    }
  }
}
else
{
  Console.Write("Введено некорректное число");
}


