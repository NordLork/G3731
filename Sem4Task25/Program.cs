// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

// Вариант 1
// Запрос пользователю
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
  Console.Write(msg1);
  Console.WriteLine(msg2);
}

// Метод возведения в степень
int Pow(int a, int b)
{
  int res = 1;
  while (b > 0)
  {
    b = b - 1;
    res = res * a;
  }
  return res;
}

int rez = 0;
int letA = ReadData("Введите число A: ");
int letB = ReadData("Введите число B: ");
rez = Pow(letA, letB);
PrintData("Число A в натуральной степени B равно ", rez);

// Вариант 2

// Запрос строки выражения
// string ReadDataStr(string msg)
// {
//   Console.Write(msg);
//   return Console.ReadLine() ?? "0";
// }

// // Решение выражения
// int oper(string msg)
// {
//   int[] res = msg.Split("+-*/^(),;".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
//   int rezult = 0;
//   if (msg.Contains('+')) rezult = res[0] + res[1];
//   if (msg.Contains('-')) rezult = res[0] - res[1];
//   if (msg.Contains('*')) rezult = res[0] * res[1];
//   if (msg.Contains('/')) rezult = res[0] / res[1];
//   if (msg.Contains('^')) rezult = Pow(res[0], res[1]);
// }

// int rez = 0;
// string stroka = ReadDataStr("Введите выражения формата A+B c опеаторами +,-,*,/,^ : ");
// rez = oper(stroka);
// PrintData("Равно ", rez);
