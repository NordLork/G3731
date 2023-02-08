// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Чтение данных из консоли
int ReadData(string line)
{
  Console.Write(line);
  int number = int.Parse(Console.ReadLine() ?? "0");
  return number;
}

// Тетстируем на повтор
bool Test(int[] array, int elem, int n)
{
  for (int t = 0; t < n; t++)
    if (elem == array[t]) return true;
  return false;
}

// Заполняем массив случайными неповторяющимися двузначными числами
int[,,] Gen3DArray(int coordX, int coordY, int coordZ)
{
  int[,,] array3D = new int[coordX, coordY, coordZ];
  int[] temp = new int[coordX * coordY * coordZ];
  for (int i = 0; i < temp.Length; i++)
  {
    temp[i] = new Random().Next(10, 100);
    while (Test(temp, temp[i], i) == true)
      temp[i] = new Random().Next(10, 100);
  }
  int count = 0;
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
  return array3D;
}

// Печать 3D массива по строкам
void Print3DArray(int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.WriteLine($"{array3D[i, j, k]} ({i},{j},{k})");
      }
      // Console.WriteLine();
    }
    Console.WriteLine();
  }
}


int x = ReadData("Величина массива по X: ");
int y = ReadData("Величина массива по Y: ");
int z = ReadData("Величина массива по Z: ");
int[,,] matrix = Gen3DArray(x, y, z);
Print3DArray(matrix);
