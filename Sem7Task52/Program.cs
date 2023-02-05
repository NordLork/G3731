// Задача 52. Задайте двумерный массив 
// из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее 
// арифметическое по диагоналям и 
// диагональ выделить разным цветом.

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Запрос значения
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Генерируем 2D массив 
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
  int i = 0; int j = 0;
  int[,] outArray = new int[countRow, countColumn];
  while (i < countRow)
  {
    j = 0;
    while (j < countColumn)
    {
      outArray[i, j] = new Random().Next(minValue, maxValue + 1);
      j++;
    }
    i++;
  }
  return outArray;
}

// Метод для печати двумерного массива
void Print2DArray(int[,] inputArray)
{
  int i = 0; int j = 0;
  while (i < inputArray.GetLength(0))
  {
    j = 0;
    while (j < inputArray.GetLength(1))
    {
      Console.Write(inputArray[i, j] + "\t ");
      j++;
    }
    // Console.Write("\n");
    Console.WriteLine();
    i++;
  }
}

// Метод расчёта среднего арифметического 2D массива по столбцам
double[] MeanColum(int[,] arr)
{
  double[] means = new double[arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      means[i] += arr[j, i];
    }
    means[i] = means[i] / arr.GetLength(0);
  }
  return means;
}

// Считаем диагональ
double[] DiagMean(int[,] arr)
{
  double[] res = new double[2];
  int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

  for (int i = 0; i < min; i = i + 1)
  {
    res[0] = res[0] + arr[i, i];
  }
  res[0] = res[0] / min;
  int j = 0;
  for (int i = 0; i < min; i = i + 1)
  {
    res[1] = res[1] + arr[i, min - 1 - j];
    j++;
  }
  return res;
}

// Метод для печати двумерного массива с цветными диагоналями
void Print2DArrayCol(int[,] inputArray, int col1, int col2)
{
  int i = 0; int j = 0;
  int min = inputArray.GetLength(0) > inputArray.GetLength(1) ? inputArray.GetLength(1) : inputArray.GetLength(0);
  while (i < inputArray.GetLength(0))
  {
    j = 0;
    while (j < inputArray.GetLength(1))
    {
      if (i == j)
      {
        Console.ForegroundColor = col[col1];
        Console.Write(inputArray[i, j] + "\t ");
        Console.ResetColor();
      }
      else
      {
        if (i == min - 1 - j)
        {
          Console.ForegroundColor = col[col2];
          Console.Write(inputArray[i, j] + "\t ");
          Console.ResetColor();
        }
        else
        {
          Console.Write(inputArray[i, j] + "\t ");
        }
      }
      j++;
    }
    // Console.Write("\n");
    Console.WriteLine();
    i++;
  }
}

// Вывод значений средних диагоналей
void PrintMeanCol(double[] arr, int around, int first, int second)
{
  Console.Write("Среднее арифметическое по диагоналям: ");
  Console.ForegroundColor = col[first];
  Console.Write(Math.Round(arr[0], around) + "\t ");
  Console.ResetColor();
  Console.ForegroundColor = col[second];
  Console.Write(Math.Round(arr[1], around) + "\t ");
  Console.ResetColor();
}


// Вариант 1
// int n = ReadData("Количество строк матрицы: ");
// int m = ReadData("Количество столбцов матрицы: ");
// int[,] matix = Gen2DArray(n, m, -100, 100);
// Print2DArray(matix);
// double[] mean = MeanColum(matix);
// Console.WriteLine("Средние арифметические по столбцам: ");
// Print1DArr(mean, 1);


// Вариант 2
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matix = Gen2DArray(n, m, -100, 100);
double[] diag = DiagMean(matix);
Print2DArrayCol(matix, 13, 11);
PrintMeanCol(diag, 2, 13, 11);
