// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Рекурсия считает сумму
int RecSum(int m, int n)
{
  if (m >= n)
  {
    return n;
  }
  else
  {
    return m + RecSum(m + 1, n);
  }
}

// Печать результата
void PrintResult(string prefix)
{
  Console.WriteLine(prefix);
}

int m = ReadData("Введите M: ");
int n = ReadData("Введите N: ");
int res = m < n ? RecSum(m, n) : RecSum(n, m);
PrintResult($"Сумма чисел от {m} до {n} = {res}");
