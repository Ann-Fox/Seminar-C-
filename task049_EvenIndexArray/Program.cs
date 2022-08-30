// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 [2,2]

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      result[i, j] = new Random().Next(minValue, maxValue + 1);
  return result;
}

int[,] CorrectArray(int[,] array)
{
  int[,] result = new int[array.GetLength(0),  array.GetLength(1)];

  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0)
      {
        result[i, j] = array[i, j] * array[i, j];
      }
      else
      {
        result[i, j] = array[i, j];
      }
    }
  return result;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)


      Console.Write($"{array[i, j]} ");
    Console.WriteLine();
  }
}
Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 100);
int[,] correctArray = CorrectArray(myArray);
PrintArray(myArray);
Console.WriteLine();
PrintArray(correctArray);

