// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру 
// разного цвета(цветов всего 16)

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

// Генерируем вещественный 2D массив 
double[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
  int i = 0; int j = 0;
  double[,] outArray = new double[countRow, countColumn];
  while (i < countRow)
  {
    j = 0;
    while (j < countColumn)
    {
      outArray[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);
      j++;
    }
    i++;
  }
  return outArray;
}

//Метод для печати двумерного массива
void Print2DArray(double[,] inputArray, int around)
{
  int i = 0; int j = 0;
  while (i < inputArray.GetLength(0))
  {
    j = 0;
    while (j < inputArray.GetLength(1))
    {
      // Console.Write("\t " + Math.Round(inputArray[i, j], 4) + " ");
      // Console.Write("\t ");
      ColorLine(Math.Round(inputArray[i, j], around));
      Console.Write(" ");
      j++;
    }
    // Console.Write("\n");
    Console.WriteLine();
    i++;
  }
}

// Метод печати цветных чисел
void ColorLine(double num)
{
  string str = num.ToString();
  for (int k = 0; k <= str.Length - 1; k++)
  {
    Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0, 16));
    Console.Write(str.Substring(k, 1));
    Console.ResetColor();
  }
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество строк матрицы: ");
int r = ReadData("Количество знаков после запятой: ");
double[,] matix = Gen2DArray(n, m, -100, 100);
Print2DArray(matix, r);
