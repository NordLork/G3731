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



// Вариант 2

// int inputNumber = ReadData("Enter number: ");

// PrintData("Result: " + DegToBin(inputNumber));
// PrintData("Result: " + DecToBinNativ(inputNumber));
// PrintData("Result: " + Convert.ToString(inputNumber, 8));
// PrintData("Result: " + Convert.ToString(inputNumber, 16));

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// string DegToBin(int num)
// {
//     string outBin = String.Empty;
//     while (num > 0)
//     {
//         outBin = (num % 2) + outBin;
//         num = num / 2;
//     }
//     return outBin;
// }

// string DecToBinNativ(int num)
// {
//     return Convert.ToString(num, 2);
// }
