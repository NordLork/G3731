// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

// Console.Write("input yor day num: ");
// string? inputNum = Console.ReadLine();
// if (inputNum != null){
//     int num = int.Parse(inputNum);
//     for (int i = 0; i < num*2; i++){
//         Console.Write(i-num);
//         Console.Write(", ");
//     }
// }

// Console.Write("input your num: ");
// string? inputNum = Console.ReadLine();
// if (inputNum != null){
//     int num = int.Parse(inputNum);
//     for (int i = 0; i < num*2; i++){
//         Console.Write(i-num);
//         Console.Write(", ");
//     }
// }


//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputNumLine != null)
{
  // Парсим введенное число
  int imputNumberA = int.Parse(imputNumLine);
  // Вводим промежуточное значение
  int imputNumberC = imputNumberA * (-1);
  // Выходные значения
  string outNumLine = string.Empty;
  // 
  while (imputNumberC < imputNumberA)
  {
    outNumLine = outNumLine + imputNumberC + ",";
    imputNumberC = imputNumberC + 1;
  }
  outNumLine = outNumLine + imputNumberA;
  Console.WriteLine(outNumLine);
}


// Console.Write("input your num: ");
// string? inputNum = Console.ReadLine();
// if (inputNum != null){
//     int num = int.Parse(inputNum);
//     for (int i = 0; i < num*2+1; i++){
//         Console.Write(i-num);
//         Console.Write(", ");
//     }
// }