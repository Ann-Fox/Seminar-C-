// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  Console.WriteLine(res);

  return res;
}


int[] GetCopy(int[] array)
{
  int[] result = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    result[i] = array[i];
  }
  return result;
}

int[] myArray = GetArray(5, 0, 10);
Console.WriteLine(String.Join(" ", GetCopy(myArray)));
