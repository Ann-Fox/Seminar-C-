// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 54321 

Console.Write("Введите пятизначное число: ");

int Pal = int.Parse(Console.ReadLine());

if (9999 < Pal && Pal < 100000)
{
  int a1 = Pal % 10;
  Console.WriteLine(a1);

  int a2 = Pal % 100 / 10;
  Console.WriteLine(a2);

  int a4 = Pal / 1000 % 10;
  Console.WriteLine(a4);

  int a5 = Pal / 10000;
  Console.WriteLine(a5);

  if (a1 == a5 && a2 == a4)
  {
    Console.WriteLine($"{Pal} -> yes");
  }
  else
  {
    Console.WriteLine($"{Pal} -> no");
  }
}
else
{
  Console.WriteLine("Введено некорректное число");
}

