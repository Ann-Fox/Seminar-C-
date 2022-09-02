// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// m = 1, n =7 -> такого числа в массиве нет

Console.Write("Введите номер строки row = ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца col = ");
int col = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];

  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      result[i, j] = new Random().Next(minValue, maxValue + 1);
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

// Функция ничего не возвращает, не удалось реализовать данное условие "возвращает значение этого элемента или же указание, что такого элемента нет"
//  Разный вид возвращаемых значений, как преобразовать?

void SearchElement(int[,] arr)
{
  if (row > arr.GetLength(0) || col > arr.GetLength(1))
  {
    Console.Write("такого числа в массиве нет");
  }

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
      if (row == i && col == j)
        Console.Write(arr[row, col]);
  }
}

Console.WriteLine();
int[,] myArray = GetArray(3, 4, 0, 10);
PrintArray(myArray);
Console.Write($"row = {row}, col = {col} -> ");
SearchElement(myArray);