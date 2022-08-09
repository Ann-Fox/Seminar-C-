/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

if (a%7 == 0 && a%23 == 0) {
  Console.WriteLine($"{a} -> yes");
} else {
  Console.WriteLine($"{a} -> no");
}