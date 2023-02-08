// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// (строка умножаются на столбец поэлементно и 
// поизведения складываются в элемент новой матрицы)

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
  int[,] matr = new int[raw, col];
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(min, max + 1);
    }
  }
  return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} \t");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

// Произведение матриц
int[,] MatrixMultiplication(int[,] A, int[,] B)
{
  int[,] C = new int[A.GetLength(0), B.GetLength(1)];
  for (int i = 0; i < A.GetLength(0); i++)
  {
    for (int j = 0; j < B.GetLength(1); j++)
    {
      C[i, j] = 0;
      for (int k = 0; k < A.GetLength(1); k++)
      {
        C[i, j] += A[i, k] * B[k, j];
      }
    }
  }
  return C;
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix1 = Gen2DArray(n, m, -100, 100);
Print2DArray(matrix1);
Console.WriteLine("Генерируем вторую матрицу для умножения на первую: ");
int[,] matrix2 = Gen2DArray(m, n, -100, 100);
Print2DArray(matrix2);
// Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
int[,] matrix3 = MatrixMultiplication(matrix1, matrix2);
Print2DArray(matrix3);
