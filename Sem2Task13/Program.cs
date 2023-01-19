// Задача 13: Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет.

// Вариант 1
//  Console.Write("Введите число: ");
//  char[] digits = Console.ReadLine().ToCharArray();
//  if (digits.Length > 2)
//  {
//    Console.WriteLine("Третья цифра: " + digits[2]);
//  }
//  else
//  {
//    Console.WriteLine("Третьей цифры нет.");
//  }

// Вариант 2
Console.Write("Введите число: ");
long num = int.Parse(Console.ReadLine() ?? "0");
// Счётчик разряда числа
int i = 0;
long raz = num;
while (raz > 0)
{
  raz /= 10;
  i++;
}
// Проверка и вывод результата
if (i > 2)
{
  num = num / (int)Math.Pow(10, i - 3);
  num = num % 10;
  Console.WriteLine("Третья цифра: " + num);
}
else
{
  Console.WriteLine("Третьей цифры нет.");
}