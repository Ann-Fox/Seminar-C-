// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int GetArray()
{
  int[] res = new int[123];
  int count = 0;

  for (int i = 0; i <res.Length; i++)
  {
    res[i] = new Random().Next(0,1000);

    if (res[i] < 100 && res[i] > 9)
    {
      count++;
    }
  }
  Console.WriteLine(string.Join(" ", res));
  return count;
}

// Console.WriteLine(string.Join(" ", array));
Console.WriteLine(GetArray());
