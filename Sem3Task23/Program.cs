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

// int TakeData(string msg)
// {
//   Console.Write(msg);
//   return int.Parse(Console.ReadLine() ?? "0");
// }

// void DrawUniLine(string sampleStr, string startSym, string midSym, string stopSym)
// {
//   Console.Write(startSym);
//   int i = 1;
//   while (1 < sampleStr.Length - 1)
//   {
//     if (sampleStr[i] == '\u2551') Console.Write(midSym);
//     else Console.Write("\u2550");
//     i++;
//   }
//   Console.WriteLine(stopSym);
// }

// int topNum = TakeData("Введите целое число больше 0: ");

// while (topNum < 1)
// {
//   Console.WriteLine("Число должно быть больше 0!");
//   topNum = TakeData("Введите целое число больше 0: ");
// }

// int i = 1;
// int cube = 0;
// int numDigitsCube = 0;
// string fistStr = "\u2551 Число:   \u2551";
// string secStr = "\u2551 Куб числа:   \u2551";

// while (1 <= topNum)
// {
//   cube = (int)Math.Pow(i, 3);
//   numDigitsCube=(int)Math.Log10(cube) + 1;
//   fistStr = fistStr + ((i).ToString()).PadRight(numDigitsCube) + "\u2551";
//   secStr = secStr + cube.ToString() + "\u2551";
//   i++;
// }

// DrawUniLine(fistStr, "\u2554", "\u2566", "u2557");
// Console.WriteLine(fistStr);
// DrawUniLine(fistStr, "\u2560", "\u256C", "u2563");
// Console.WriteLine(secStr);
// DrawUniLine(fistStr, "\u255A", "\u2569", "u255D");


// Вариант 4

int topNum = TakeData("Введите целое число больше 0: "); // читаем число из консоли 

while (topNum<1){ // Проверяем корректность воода, если нет то сообщаем об этом и просим ввести корректное число
    Console.WriteLine("Число должно быть больше 0!");
    topNum = TakeData("Введите целое число больше 0: ");
}


int i=0; // счетчик для цикла
int cube=0; // куб числа
int numDigitsCube=0;  // количество цифр в кубе числа
string firstStr="\u2551 Число:    \u2551"; // первая строка таблицы с границами в виде псевдографики
string secStr="\u2551 Куб числа:\u2551"; // вторая строка таблицы с границами в виде псевдографики

while(i<topNum){
    cube=(int)Math.Pow(i+1,3); // вычисляем куб числа
    numDigitsCube=(int)Math.Log10(cube) + 1; // вычисляем количество цифр в кубе числа через логарифм
    firstStr=firstStr+((i+1).ToString()).PadRight(numDigitsCube)+"\u2551"; // дополняем первую строку таблицы числом, необходимым количеством пробелов и границей ячейки таблицы
    secStr=secStr+cube.ToString()+"\u2551"; // дополняем вторую строку таблицы значением куба числа и границей ячейки таблицы
    i++;
}


DrawTopLine(firstStr); // рисуем верхнюю границу таблицы
Console.WriteLine(firstStr); // выводим первую строку таблицы
DrawMidLine(firstStr); // рисуем среднюю границу таблицы
Console.WriteLine(secStr); // выводим вторую строку таблицы
DrawBottomLine(firstStr); // рисуем нижнюю границу таблицы


int TakeData (string msg) { //метод считывающий целое число из консоли, выводя в неё сообщение
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
} 


void DrawTopLine (string sampleStr){ // метод выводящий в консоль верхнюю линию таблицы используя псевдографику
    Console.Write("\u2554"); //рисуем левый верхний угол таблицы
    int i=1;
    while (i<sampleStr.Length-1){
        if(sampleStr[i]=='\u2551') Console.Write("\u2566"); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием вниз
        else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
        i++;
    }
    Console.WriteLine("\u2557"); //рисуем правый верхний угол таблицы
}

void DrawMidLine (string sampleStr){ // метод выводящий в консоль среднюю линию таблицы используя псевдографику
    Console.Write("\u2560"); //рисуем левую границу таблицы
    int i=1;
    while (i<sampleStr.Length-1){
        if(sampleStr[i]=='\u2551') Console.Write("\u256C"); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием
        else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
        i++;
    }
    Console.WriteLine("\u2563"); //рисуем правую границу таблицы
}

void DrawBottomLine (string sampleStr){ // метод выводящий в консоль нижнюю линию таблицы используя псевдографику
    Console.Write("\u255A"); //рисуем левый нижний угол таблицы
    int i=1;
    while (i<sampleStr.Length-1){
        if(sampleStr[i]=='\u2551') Console.Write("\u2569"); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием вверх
        else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
        i++;
    }
    Console.WriteLine("\u255D"); //рисуем правый нижний угол таблицы
}