// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetBinary(int n)
{
  string res = " ";  //String.Empty()

  while (n > 0)
  {
    res = res + Convert.ToInt32(n % 2);
    //  (Math.Pow(10, count));
    n = n / 2;
  }
 res.ToCharArray().Reverse();
  return int.Parse(res);
}

Console.Write($"{GetBinary(num)}");


