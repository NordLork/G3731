// Задача 19
// Напишите программу, которая принимает
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печати результата пользователя
void PrintPalinTest(bool res)
{
  if (res == true)
  {
    Console.WriteLine("Это палиндром!");
  }
  else
  {
    Console.WriteLine("Это не палиндром!");
  }
}

// Метод теста пятизначного палиндрома в цифре
bool PalinTestDig(int n)
{
  bool res = false;
  int d1 = n / 10000;
  int d2 = (n / 1000) % 10;
  int d4 = (n / 10) % 10;
  int d5 = n % 10;
  res = ((d1 == d5) && (d2 == d4)) ? true : false;
  return res;
}

// Метод теста палиндрома в символах
bool PalinTestChar(int n)
{
  string num = n.ToString();
  char[] digits = num.ToCharArray();
  int i = 0;
  int j = digits.Length - 1;
  while (i < j)
  {
    if (digits[i++] != digits[j--]) return false;
  }
  return true;
}

// Вариант 1 функциональный
// PrintPalinTest(PalinTestDig(ReadData("Введите пятизначное число: ")));

// Вариант 2
// Создаём новый словарь и очищаем
var palin5Dig = new Dictionary<int, string>();
palin5Dig.Clear();
// Заполняем словарь
for (int i = 10000; i < 100000; i++)
{
  if (PalinTestChar(i) == true) { palin5Dig.Add(i, "Это палиндром!"); }
}
// Заполнение словаря и проверка заполнения словаря
// foreach (var dig in palin5Dig)
// {
//   Console.WriteLine($"key: {dig.Key}  value: {dig.Value}");
// }
Console.WriteLine($"В словаре {palin5Dig.Count} значений пятизначных палиндромов.");
// Запрос пользователю и вывод результата
int number = ReadData("Введите пятизначное число: ");
if (number > 9999 && number < 100000)
{
  PrintPalinTest(palin5Dig.ContainsKey(number));
}
else
{
  Console.WriteLine("Это не пятизначное число!");
}