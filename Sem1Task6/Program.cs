﻿// Задача 6: Напишите программу, 
// которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Считываем данные с консоли число
string? inputNum1 = Console.ReadLine();
// Проверим, чтобы данные были не пустыми
if (inputNum1 != null)
{
  // Парсим введённое число
  int number1 = int.Parse(inputNum1);
  if (number1 % 2 == 0)
  {
    Console.WriteLine("Чётное!");
  }
  else
  {
    Console.WriteLine("Не чётное!");
  }
}