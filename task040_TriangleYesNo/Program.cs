// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

bool CheckTriangle(int n1, int n2, int n3)
{
  return n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1;
}

if (CheckTriangle(a, b, c))
{
  Console.Write("Yes");
}
else
{
  Console.Write("No");
}
}

//  CheckTriangle(3, 4, 5); что-то пошло не так, пересмотреть
