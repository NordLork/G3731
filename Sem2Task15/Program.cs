// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// Вариант 1
// Console.Write("Введите номер дня недели: ");
// int day = int.Parse(Console.ReadLine() ?? "0");
// if (day < 8 && day > 0)
// {
//   if (day > 5)
//   {
//     Console.WriteLine("Это же выходной! :)");
//   }
//   else
//   {
//     Console.WriteLine("Обычный рабочий день.");
//   }
// }
// else
// {
//   Console.WriteLine("Это не похоже на день недели :(");
// }

// Вариант 2
// Задаём словарь
Dictionary<int, string> week = new Dictionary<int, string>
{
  { 1, "Рабочий" },
  { 2, "Рабочий" },
  { 3, "Рабочий" },
  { 4, "Рабочий" },
  { 5, "Рабочий" },
  { 6, "Выходной" },
  { 7, "Выходной" },
};
// Вводим число
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine() ?? "0");
if ((day > 0) && (day < 8))
{
  Console.WriteLine(week[day]);
}
else
{
  Console.WriteLine("Это не день недели.");  
}