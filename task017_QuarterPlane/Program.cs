// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// image.png
// четверти 2/1
//          3/4

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.Write("1");
if (x < 0 && y > 0) Console.Write("2");
if (x < 0 && y < 0) Console.Write("3");
if (x > 0 && y < 0) Console.Write("2");
