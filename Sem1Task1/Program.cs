// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

// Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

// Проверим, чтобы данные были не пустыми
if (inputNum1 != null && inputNum2 != null)
{
  // Парсим введённое 1 число
  int number1 = int.Parse(inputNum1);
  // Парсим введённое 2 число
  int number2 = int.Parse(inputNum2);

  if (number1 == number2 * number2)
  {
    Console.WriteLine("Первое число квадрат второго!");
  }
  else
  {
    Console.WriteLine("Первое число не квадрат второго!");
  }
}
