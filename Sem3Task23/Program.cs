// Задача 23
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.

// Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// Выводим результат пользователю
// void PrintData(string msg1, string msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

// Вывод нахождения степени чисел от 1 до N
// string LineBuilder(int n, int p)
// {
//     string s = "";
//     for (int i = 1; i <= n; i++)
//     {
//         s += Math.Pow(i, p).ToString() + "\t ";
//     }
//     return s;
// }

// Вывод нахождения степени чисел от 1 до N для таблицы
// string LineBuilderTabl(int n, int p)
// {
//     string s = "";
//     for (int i = 1; i <= n; i++)
//     {
//         s += "|"+Math.Pow(i, p).ToString() + "\t ";
//     }
//     s += "|";
//     return s;
// }

// Вывод результата таблицей в консоли
// void PrintTabl(string msg1, string msg2, string msg3)
// {
//     int tableWidth=msg1.Length;
//     Console.WriteLine(new string('—', 2*tableWidth));
//     Console.WriteLine(msg1);
//     Console.WriteLine(new string('—', 2*tableWidth));
//     Console.WriteLine(msg2);
//     Console.WriteLine(new string('—', 2*tableWidth));
//     Console.WriteLine(msg3);
//     Console.WriteLine(new string('—', 2*tableWidth));   
// }

//Вариант 1
// // Ввод данных
// int num = ReadData("Введите N: ");
// //Собираем первую строчку таблицы
// string line1 = LineBuilder(num, 1);
// //Собираем вторую строчку таблицы
// string line2 = LineBuilder(num, 3);
// // Вывод данных
// PrintData(line1,line2);

// Вариант 2
// Ввод данных
// int num = ReadData("Введите N: ");
// //Собираем первую строчку таблицы
// string line1 = LineBuilderTabl(num, 1);
// // Собираем вторую строчку таблицы
// string line2 = LineBuilderTabl(num, 2);
// // Собираем третью строчку таблицы
// string line3 = LineBuilderTabl(num, 3);
// // Вывод данных
// PrintTabl(line1,line2,line3);

// Вариант 3

int TakeData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

void DrawUniLine(string sampleStr, string startSym, string midSym, string stopSym)
{
  Console.Write(startSym);
  int i = 1;
  while (1 < sampleStr.Length - 1)
  {
    if (sampleStr[i] == '\u2551') Console.Write(midSym);
    else Console.Write("\u2550");
    i++;
  }
  Console.WriteLine(stopSym);
}

int topNum = TakeData("Введите целое число больше 0: ");

while (topNum < 1)
{
  Console.WriteLine("Число должно быть больше 0!");
  topNum = TakeData("Введите целое число больше 0: ");
}

int i = 1;
int cube = 0;
int numDigitsCube = 0;
string fistStr = "\u2551 Число:   \u2551";
string secStr = "\u2551 Куб числа:   \u2551";

while (1 <= topNum)
{
  cube = (int)Math.Pow(i, 3);
  numDigitsCube = (int)Math.Log10(cube) + 1;
  fistStr = fistStr + ((i).ToString()).PadRight(numDigitsCube) + "\u2551";
  secStr = secStr + cube.ToString() + "\u2551";
  i++;
}

DrawUniLine(fistStr, "\u2554", "\u2566", "u2557");
Console.WriteLine(fistStr);
DrawUniLine(fistStr, "\u2560", "\u256C", "u2563");
Console.WriteLine(secStr);
DrawUniLine(fistStr, "\u255A", "\u2569", "u255D");
