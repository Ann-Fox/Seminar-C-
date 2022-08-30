// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

//0,0 
    // 1,1
        //2,2

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
      result[i, j] = new Random().Next(minValue, maxValue + 1);
  return result;
}

int CorrectArray(int[,] array)
{
  int result = 0;

  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i==j)
      {
        result += array[i, j];
      }
      else
      {
        result = 0;
      }
    }
  return result;
}

Console.Write("m= ");
int m = int.Parse(Console.ReadLine());
Console.Write("n= ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, 0, 100);
int correctArray = CorrectArray(myArray);
PrintArray(myArray);
Console.WriteLine();
PrintArray(correctArray);

/*Задача 51.*/


// Console.Write("n= ");
// int n = int.Parse(Console.ReadLine());
// Console.Write("m= ");
// int m = int.Parse(Console.ReadLine());

// int[,] GetArray(int n, int m, int minValue, int maxValue)
// {
//     int[,] result = new int[n, m];

//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }

// int SumDiagonalArray(int[,] array)
// {
//     int diagSum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j )
//             {
//                 diagSum += array[i, j];
//             }
//         }
//     }
//     return diagSum;
// }

// int[,] myArray = GetArray(n,
