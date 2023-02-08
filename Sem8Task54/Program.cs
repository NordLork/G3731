// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Метод сортировки пузырьком
int[] BubbleSort(int[] arr)
{
  int swap = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    for (int j = i + 1; j < arr.Length; j++)
    {
      if (arr[i] > arr[j])
      {
        swap = arr[i];
        arr[i] = arr[j];
        arr[j] = swap;
      }
    }
  }
  return arr;
}

// Метод сортировки двумерного массива
void Sort2DArr(int[,] arr)
{
  int[] bufA = new int[arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      bufA[j] = arr[i, j];
    }
    bufA = BubbleSort(bufA);
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = bufA[j];
    }
  }
}

int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");
int[,] matix = Gen2DArray(n, m, -100, 100);
Print2DArray(matix);
Console.WriteLine("Двумерный массив с упорядоченными по убыванию элементами каждой строки: ");
Sort2DArr(matix);
Print2DArray(matix);
