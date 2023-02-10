// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Печать результата
void PrintResult(string prefix)
{
  Console.WriteLine(prefix);
}

// Рекурсия для вывода чисел
int NaturalNumber(int n, int m)
{
  if (n == m)
    return n;
  else
    Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}

int m = 1;
int n = ReadData("Введите число N больше 1: ");
while (n < 1)
{
  n = ReadData("Введите число N больше 1: ");
}
Console.WriteLine(NaturalNumber(n, m));
