// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size)
{
  int[] res = new int[size];

  for (int i = 0; i < res.Length; i++)
  {
    res[i] = new Random().Next(-10, 10);
  }
  return res;
}

int[] BubbleSort(int[] array)
{
  int temp;
  for (int i = 0; i < array.Length; i++)
  {
    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[i] < array[j])
      {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
    }
  }
  return array;
}

int[] array = GetArray(5);
Console.WriteLine($"[{String.Join(" ", array)}]");
BubbleSort(array);
Console.WriteLine($"[{String.Join(" ", array)}]");


