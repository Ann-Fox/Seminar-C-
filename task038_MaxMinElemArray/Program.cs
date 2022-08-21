// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементоm массива.
// [3 7 22 2 78] -> 76


double[] GetArray(int size)
{
  double[] res = new double[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = Math.Round((new Random().NextDouble() * 100));
        // res[i] = Math.Round((new Random().NextDouble() * 100),2); округление до 2 знаков после запятой

  }
  return res;
}


double MaxMinSum(double[] arr)
{
  double max = arr[0];
  double min = arr[0];

  for (int i = 1; i < arr.Length; i++)
  {
    max = (arr[i] > max) ? arr[i] : max;
  }
  Console.WriteLine($"max = {max}");


   for (int i = 1; i < arr.Length; i++)
  {
    min = (arr[i] < min) ? arr[i] : min;
  }
  Console.WriteLine($"min = {min}");

  double result = max - min;
  return result;
}

double[] array = GetArray(5);
Console.WriteLine($"[{string.Join(" ", array)}] -> {MaxMinSum(array)}");



// double maxVal = MaxElement(array);
// Console.Write(maxVal);
