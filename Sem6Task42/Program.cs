// Задача №42
// Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.Write(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// Вывод значения
void PrintData(string res)
{
  Console.WriteLine(res);
}

// Метод перевода в двоичное число
string toBinaryNumberSystem(int a)
{
  string numBinary = "0";
  if (a == 0) return numBinary;
  else
  {
    while (a > 0)
    {
      numBinary = Convert.ToString(a % 2) + numBinary;
      a = a / 2;
    }
  }
  return numBinary;
}

int number = -1;
while (number < 0) number = ReadData("Введите целое число: ");
string res = toBinaryNumberSystem(number);
PrintData("Введённое число в двоичном виде: " + res);
