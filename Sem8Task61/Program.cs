// Задача №61
// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

//Вычисляем факториал
float Factor(int n)
{
  float i, x = 1;
  for (i = 1; i <= n; i++)
  {
    x *= i;
  }
  return x;
}

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}


//_ _ _ _ _ 1
//_ _ _ _  1 1
void PrintPascalTriangle(int nRow)
{
  for (int i = 0; i < nRow; i++)
  {

    for (int j = 0; j <= nRow - i; j++)
    {
      Console.Write(" ");
    }

    for (int j = 0; j <= i; j++)
    {
      // создаём пробелы между элементами треугольника
      Console.Write(" ");
      //формула вычисления элементов треугольника
      Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
    }
    Console.WriteLine();
  }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPascalTriangle(countRow);


// // Вариант 2
// //Количество строк
// int row = 5;
// int[,] triangle = new int[row, row];
// // Ширина для вывода одно слота числа в треугольнике
// // const int cellWidth = 3;
// const int cellWidth = 1;

// void FillTriangle()
// {
//   for (int i = 0; i < row; i++)
//   {
//     triangle[i, 0] = 1;
//     triangle[i, i] = 1;
//   }
//   for (int i = 2; i < row; i++)
//   {
//     for (int j = 1; j <= 1; j++)
//     {
//       triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
//     }
//   }
// }

// void PrintTriangle()
// {
//   for (int i = 0; i < row; i++)
//   {
//     for (int j = 0; j < row; j++)
//     {
//       if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
//     }
//     Console.WriteLine();
//   }
// }

// void Magic()
// {
//   int col = cellWidth * row;
//   for (int i = 0; i < row; i++)
//   {
//     for (int j = 0; j <= row; i++)
//     {
//       Console.SetCursorPosition(col, i + 1);
//       // if (triangle[i, j] != 0) Console.WriteLine($"{triangle[i, j],cellWidth}");
//       // if (triangle[i, j] != 0) Console.WriteLine("*");
//       if (triangle[i, j] % 2 != 0) Console.WriteLine("*");
//       col += cellWidth * 2;
//     }
//     col = cellWidth * row - cellWidth * (i + 1);
//     Console.WriteLine();
//   }
// }

// // Console.ReadLine();
// FillTriangle();
// // PrintTriangle();
// // Console.ReadLine();
// Magic();
