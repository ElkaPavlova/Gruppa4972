//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadData(string line) // Ввод данных
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int Akkerman(int n, int m)// функция Аккермана
{
  if (n == 0)
   return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman (n - 1, 1);
    else
      return Akkerman (n - 1, Akkerman(n, m - 1));
}

int n = ReadData("Введите число n: ");
int m = ReadData("Введите число m: ");
Console.WriteLine("Результат вычисления функции Аккермана - " + Akkerman(n, m));