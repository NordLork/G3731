// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Метод проверяет, может ли существовать треугольник с заданными сторонами
void Triangle(int a, int b, int c)
{
  if ((a + b > c) && (b + c > a) && (a + c > b))
  {
    Console.WriteLine("Треугольник существует.");
  }
  else
  {
    Console.WriteLine("Треугольник не существует.");
  }
}

int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");
Triangle(a, b, c);



// Вариант 2

// int a = ReadData("Введите первое число: ");
// int b = ReadData("Введите второе число: ");
// int c = ReadData("Введите третье число: ");

// if (TriangleTest(a, b, c)) PrintData("Может существовать треугольник сo сторонами такой длины.");
// else PrintData("Треугольник сo сторонами такой длины не существует.");
// //Метод, считывающий данные, введенные пользователем
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод, выводящий на печать данные пользователю
// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// bool TriangleTest(int a, int b, int c)
// {
//     return ((a + b > c) && (a + c > b) && (b + c > a));
// }

// int A = ReadData("Enter first number: ");//1c
// int B = ReadData("Enter second number: ");//1c
// int C = ReadData("Enter third number: ");//1c
// TriangleTest(A,B,C);//50c
// PrintData("Result: " + TriangleTest(A, B, C));//1

//103c

// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string res)
// {
//   Console.WriteLine(res);
// }

// bool TriangleTest(int a, int b, int c)
// {
//   return ((a + b > c) && (a + c > b) && (b + c > a));
// }
