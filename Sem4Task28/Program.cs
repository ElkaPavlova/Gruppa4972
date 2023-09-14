// Задача №28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

long Factorial(int num)
{
    long res = 1;
    for (int i = 2; i <= num; i++)
    {
    res = res * i;
    }
    return res;
}

int n = ReadData("Введите число: ");
long res = Factorial(n);
PrintResult("Факториал = " + res);