// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа n и m.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29

using System;
using System.Numerics;

// Чтение данных из консоли
BigInteger ReadData(string line)
{
  Console.Write(line);
  BigInteger number = BigInteger.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Рекупсия для функции Аккермана
BigInteger Akkerman(BigInteger n, BigInteger m)
{
  if (n == 0)
    return m + 1;
  if (n != 0 && m == 0)
    return Akkerman(n - 1, 1);
  else
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

BigInteger n = -1;
BigInteger m = -1;
while (n < 0 && m < 0)
{
  Console.WriteLine("Введите два положительных числа: N и M.");
  n = ReadData("Введите N: ");
  m = ReadData("Введите M: ");
}
Console.WriteLine($"A ({n}, {m}) = {Akkerman(n, m)}");
