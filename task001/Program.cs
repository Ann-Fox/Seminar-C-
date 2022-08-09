// Задача 1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

  Console.Write("Введите число a: ");
  int a = int.Parse(Console.ReadLine());

  Console.Write("Введите число b: ");
  int b = int.Parse(Console.ReadLine());


if(a == b*b) {
  Console.WriteLine($"a = {a}; b = {b} -> yes");
} else {
  Console.WriteLine($"a = {a}; b = {b} -> no");
}
