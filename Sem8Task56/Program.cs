// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
      Console.Write($"{matr[i, j],3} ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

// Поиск строки с минимальной суммой элементов в матрице
(int x, int y) SearchMinSumElem(int[,] matr)
{
  int buf = 0;
  int row = -1;
  int min = int.MaxValue;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      buf += matr[i, j];
    }
    if (buf < min)
    {
      min = buf;
      row = i + 1;
    }
    buf = 0;
  }
  return (min, row);
}


int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matrix = Gen2DArray(n, m, -100, 100);
Print2DArray(matrix);
(int x, int y) minElem = SearchMinSumElem(matrix);
Console.WriteLine($"Минимальная сумма всех элементов в одной строке {minElem.x}. {minElem.y} строка.");
