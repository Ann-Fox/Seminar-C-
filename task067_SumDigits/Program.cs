// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());


// int Summ(int a)
// {
//   int i = 0;
//   int sum = 0;

//   // int b = 0;
//   while (a > 0)
//   {

//     sum += (a % 10);  //  b = a % 10;
//     a = a / 10;
//   }
//   return sum;
// }

int SummRec(int a)
{
  if (a <= 0) return 0;
  return a % 10 + SummRec(a / 10);
}
Console.WriteLine(SummRec(123));
// int res1 = Summ(num);
// Console.WriteLine($"{num} -> {res1}");
