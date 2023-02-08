// Задача 62. Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// Например, на выходе получается 
// вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j],3} "); // маска вывода числа со значением символов
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

int n = ReadData("Задайте размер для квадратной матрицы: ");
int[,] Matrix = new int[n, n];
int num = 1;
int i = 0;
int j = 0;
while (num <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
Print2DArray(Matrix);
