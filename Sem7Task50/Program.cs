// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение 
// этого элемента или же указание, что 
// такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить 
// цветом найденную цифру

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

//Метод для печати двумерного массива
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

// Метод поиска числа
void SearchElem(int[,] arr, int elem)
{
  bool elemFind = false;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (elem == arr[i, j])
      {
        Console.WriteLine($"Число найдено: cтрока {i + 1}, cтолбец {j + 1}.");
        elemFind = true;
      }
    }
  }
  if (elemFind == false) Console.WriteLine("Число не найдено.");
}

// Генерируем 2D массив Фибоначчи
int[,] Gen2DArrayFibonacci(int countRow, int countColumn)
{
  int[,] outArray = new int[countRow, countColumn];
  int razmer = countRow * countColumn;
  int[] fibonacciArray = Fibonacci(razmer);
  int i = 0; int j = 0; int k = 0;
  while (i < countRow)
  {
    j = 0;
    while (j < countColumn)
    {
      outArray[i, j] = fibonacciArray[k];
      k++;
      j++;
    }
    i++;
  }
  return outArray;
}

// Метод Фибоначчи
int[] Fibonacci(int num)
{
  int[] arr = new int[num];
  arr[0] = 0;
  arr[1] = 1;
  for (int i = 2; i < num; i++)
  {
    arr[i] = arr[i - 1] + arr[i - 2];
  }
  return arr;
}

// Метод для печати двумерного массива с поиском цифры
void Print2DArrayColor(int[,] inputArray, int number)
{
  int i = 0; int j = 0;
  while (i < inputArray.GetLength(0))
  {
    j = 0;
    while (j < inputArray.GetLength(1))
    {
      FindNum(inputArray[i, j], number);
      Console.Write("\t ");
      j++;
    }
    // Console.Write("\n");
    Console.WriteLine();
    i++;
  }
}

// Метод поиска цифры
void FindNum(int num, int find)
{
  string str = num.ToString();
  string charNum = find.ToString();
  for (int k = 0; k <= str.Length - 1; k++)
  {
    if (str.Substring(k, 1) == charNum)
    {
      Console.ForegroundColor = col[13];
      Console.Write(str.Substring(k, 1));
      Console.ResetColor();
    }
    else
    {
      Console.Write(str.Substring(k, 1));
    }
  }
}

// Вариант 1
// int n = ReadData("Количество строк матрицы: ");
// int m = ReadData("Количество столбцов матрицы: ");
// int[,] matix = Gen2DArray(n, m, -100, 100);
// Print2DArray(matix);
// SearchElem(matix, ReadData("Какое найти число? "));


// Вариант 2
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int f = ReadData("Какую цифру будем искать? ");
int[,] matix = Gen2DArrayFibonacci(n, m);
Print2DArrayColor(matix, f);
